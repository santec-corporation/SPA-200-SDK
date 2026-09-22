using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper.Configuration.Attributes;
using SantecSPA;
using ScottPlot;
using ScottPlot.Plottable;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace SantecSPADLLTest
{
    public partial class frmMain : Form
    {
        SPAModule spa = new SPAModule();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string[] spaDeviceList = { };
            string[] tslDeviceList = { };

            // get list of SPA devices
            spa.GetSpaDeviceList(ref spaDeviceList);
            spa.GetTslDeviceList(ref tslDeviceList);

            cmbSPADevice.Items.AddRange(spaDeviceList);

            if (cmbSPADevice.Items.Count > 0)
                cmbSPADevice.SelectedIndex = 0;


            cmbTSLDevice.Items.AddRange(tslDeviceList);

            if (cmbTSLDevice.Items.Count > 0)
                cmbTSLDevice.SelectedIndex = 0;

            

        }

        private void UpdateSettings()
        {
            string setVal;

            // set the operation settings from the UI
            spa.SetOperationSettingsValue("MeasurementMode", cmbPort.SelectedIndex);
            spa.SetOperationSettingsValue("StartWave", Double.Parse(edStartWave.Text));
            spa.SetOperationSettingsValue("StopWave", Double.Parse(edStopWave.Text));
            spa.SetOperationSettingsValue("RefractiveIndex", Double.Parse(edRefractiveIndex.Text));
            spa.SetOperationSettingsValue("EnableRefractiveIndex", cbDefaultRefractiveIndex.Checked);
            spa.SetOperationSettingsValue("DistanceRange", Double.Parse(cmbDistanceRange.Text));

            spa.SetOperationSettingsValue("PeakThreshold", Double.Parse(edPeakThreshold.Text));
            spa.SetOperationSettingsValue("PeakWidth", Double.Parse(edPeakWidth.Text));

            
        }

        private void UpdateSettingsUI()
        {
            string setVal;

            // get the specified operation settings values and update the UI elements


            spa.GetOperationSettingsValue("MeasurementMode", out setVal);

            if (setVal == "0")
                cmbPort.SelectedIndex = 0;
            else if (setVal == "1")
                cmbPort.SelectedIndex = 1;
            else if (setVal == "2")
                cmbPort.SelectedIndex = 2;
            else if (setVal == "3")
                cmbPort.SelectedIndex = 3;

            
            spa.GetOperationSettingsValue("StartWave", out setVal);
            edStartWave.Text = setVal;

            spa.GetOperationSettingsValue("StopWave", out setVal);
            edStopWave.Text = setVal;

            spa.GetOperationSettingsValue("PeakThreshold", out setVal);
            edPeakThreshold.Text = setVal;

            spa.GetOperationSettingsValue("PeakWidth", out setVal);
            edPeakWidth.Text = setVal;

            spa.GetOperationSettingsValue("RefractiveIndex", out setVal);
            edRefractiveIndex.Text = setVal;

            spa.GetOperationSettingsValue("EnableRefractiveIndex", out setVal);
            if (setVal == "True")
            {
                cbDefaultRefractiveIndex.Checked = true;
            }
            else
            {
                cbDefaultRefractiveIndex.Checked = false;
            }

            spa.GetOperationSettingsValue("DistanceRange", out setVal);
            if (setVal != null)
            {
                if (cmbDistanceRange.Items.Count == 0)
                    cmbDistanceRange.Text = setVal;
                else
                    cmbDistanceRange.SelectedIndex = cmbDistanceRange.FindStringExact(setVal);
            }

        }

        private void btnInitialize_Click(object sender, EventArgs e)
        {
            int status;

            double[] distRangeList = { };

            if (cbConnectionFile.Checked)
            {
                // intialize and connect using a connection file
                status = spa.Initialize("connection.ini");

                if (status == 0)
                    MessageBox.Show("Connected.");
            }
            else
            {
                // use the connection settings specified in the UI

                string tslType = cmbTSLType.Text;
                int gpibAddr = Int32.Parse(edTSLGPIBAddress.Text);
                int usbDev = Int32.Parse(cmbTSLDevice.Text);
                string spaDev = cmbSPADevice.Text;
                string ipAddr = edIPAddress.Text;
                int port = Int32.Parse(edPort.Text);

                edSPA200WaveLimits.Visible = false;

                if (!spaDev.Contains("Dev"))
                {
                    spa.Instrument.Connection.SpaType = 1;
                    edSPA200WaveLimits.Visible = true;
                }

                status = spa.Initialize(spaDev, tslType, (uint)gpibAddr, (uint)usbDev, ipAddr, (uint)port);

                if (status == 0)
                    MessageBox.Show("Connected.");
            }
            
            // load operations settings from file
            spa.LoadOperationSettingsFromFile("settings.ini");

            spa.GetDistanceRangeTable(out distRangeList);

            if (distRangeList.Length > 0)
            {
                for (int i = 0; i < distRangeList.Length; i++)
                {
                    cmbDistanceRange.Items.Add(distRangeList[i]);
                }
            }

            UpdateSettingsUI();

        }

        private void btnReference_Click(object sender, EventArgs e)
        {
            double reference = 0;
            double peakPos;
            double[] xData, yData;
            double[] xWDL, yWDL;
            int status = 0;
            double startPos, endPos;

            btnUpdate.Enabled = false;

            if (cmbPort.SelectedIndex == 3)
            {
                // scan and process transmission reference
                status = spa.ExecuteTransmissionReference(out xData, out yData, out peakPos);
                if (status != 0)
                {
                    MessageBox.Show("Error: " + status);
                    return;
                }

                // use the peakPos found by the reference for the WDL range
                status = spa.GetTransmissionWDLData(peakPos - 5, peakPos + 5, out xWDL, out yWDL, true);
                if (status != 0)
                {
                    MessageBox.Show("Error: " + status);
                    return;
                }

                edWDLXMin.Text = (peakPos - 5).ToString("F0");
                edWDLXMax.Text = (peakPos + 5).ToString("F0");

                plotMain.Plot.Clear();
                plotMain.Plot.AddSignalXY(xData, yData);
                plotMain.Plot.SetAxisLimits(xData.Min(), xData.Max(), -200, 10);
                plotMain.Plot.XAxis.TickLabelFormat(x => (x).ToString("G"));
                plotMain.Refresh();

                plotWDL.Plot.Clear();
                plotWDL.Plot.AddSignalXY(xWDL, yWDL);
                plotWDL.Plot.SetAxisLimits(xWDL.Min(), xWDL.Max());
                plotMain.Plot.XAxis.TickLabelFormat(x => (x).ToString("G"));
                plotWDL.Refresh();
            }
            else
            {

                

                // scan and process reflection reference
                status = spa.ExecuteReflectionReference(out reference);
                if (status != 0)
                {
                    MessageBox.Show("Error: " + status);
                    return;
                }

                if (cbMeasRange.Checked)
                {
                    startPos = double.Parse(edMeasRangeMin.Text);
                    endPos = double.Parse(edMeasRangeMax.Text);
                    // get the reference xy data
                    status = spa.GetReflectanceData(startPos, endPos, out xData, out yData, true);
                }
                else
                {
                    // get the reference xy data
                    status = spa.GetReflectanceData(out xData, out yData, true);
                }
                
                if (status != 0)
                {
                    MessageBox.Show("Error: " + status);
                    return;
                }

                plotMain.Plot.Clear();
                plotMain.Plot.AddSignalXY(xData, yData);
                plotMain.Plot.SetAxisLimits(xData.Min(), xData.Max(), -200, 10);
                plotMain.Plot.XAxis.TickLabelFormat(x => (x).ToString("G"));
                plotMain.Refresh();
            }

            MessageBox.Show("Reference finished");
            
        }


        private void btnMeasure_Click(object sender, EventArgs e)
        {
            double[] xData, yData;
            int status = 0;
            double startPos, endPos, distCorrPos;

            btnUpdate.Enabled = false;

            if (cmbPort.SelectedIndex == 3)
            {
                // scan and process transmission measurement
                status = spa.ExecuteTransmissionMeasurement(out xData, out yData);
                if (status != 0)
                {
                    MessageBox.Show("Error: " + status);
                    return;
                }

                plotMain.Plot.Clear();
                plotMain.Plot.AddSignalXY(xData, yData);
                plotMain.Plot.SetAxisLimits(xData.Min(), xData.Max(), -200, 10);
                plotMain.Plot.XAxis.TickLabelFormat(x => (x).ToString("G"));
                plotMain.Refresh();
            }
            else
            {
                if (cbDispComp.Checked)
                {
                    spa.SetDispersionCompensationRegion(double.Parse(edDispCompX1.Text), double.Parse(edDispCompX2.Text));
                    spa.SetOperationSettingsValue("DispersionCompensation", true);
                }

                if (cbMeasRange.Checked)
                {
                    startPos = double.Parse(edMeasRangeMin.Text);
                    endPos = double.Parse(edMeasRangeMax.Text);

                    if (cbDistCorrPos.Checked)
                        distCorrPos = double.Parse(edDistCorrPos.Text);
                    else
                        distCorrPos = (endPos - startPos) / 2;

                    // scan and process reflection measurement
                    status = spa.ExecuteReflectionMeasurement(startPos, endPos, distCorrPos, out xData, out yData);
                }
                else
                {
                    status = spa.ExecuteReflectionMeasurement(out xData, out yData);
                }
                    
                if (status != 0)
                {
                    MessageBox.Show("Error: " + status);
                    return;
                }

                plotMain.Plot.Clear();
                plotMain.Plot.AddSignalXY(xData, yData);
                plotMain.Plot.SetAxisLimits(xData.Min(), xData.Max(), -200, 10);
                plotMain.Plot.XAxis.TickLabelFormat(x => (x).ToString("G"));
                plotMain.Refresh();
            }

            btnUpdate.Enabled = true;
            
            MessageBox.Show("Measurement finished");
        }


        // Load a DSPA file
        private void btnLoadDSPA_Click(object sender, EventArgs e)
        {
            double[] xData, yData;
            double reflReferenceOffset = 0;
            double reflReferencePeak = 0;

            var fileStatus = dlgLoadDSPA.ShowDialog();

            if (fileStatus == DialogResult.OK)
            {
                if (!String.IsNullOrEmpty(dlgLoadDSPA.FileName))
                {
                    spa = new SPAModule();

                    // load a DSPA datafile
                    spa.LoadDSPAFile(dlgLoadDSPA.FileName);

                    UpdateSettingsUI();

                    if (cmbPort.SelectedIndex == 3)
                    {
                        // process reference in DSPA
                        spa.GetTransmissionReferencePeak(out reflReferencePeak);

                        // process Transmission measurement in DSPA
                        spa.GetTransmissionData(out xData, out yData, false);

                        // graph Transmission Data
                        plotMain.Plot.Clear();
                        plotMain.Plot.AddSignalXY(xData, yData);
                        plotMain.Plot.SetAxisLimits(xData.Min(), xData.Max(), -200, 10);
                        plotMain.Plot.XAxis.TickLabelFormat(x => (x).ToString("G"));
                        plotMain.Refresh();
                    }
                    else
                    {
                        // process reference in DSPA
                        spa.GetReflectanceReferenceOffset(out reflReferenceOffset);

                        // process Reflection measurement in DSPA
                        spa.GetReflectanceData(out xData, out yData, false);

                        // graph Reflection Data
                        plotMain.Plot.Clear();
                        plotMain.Plot.AddSignalXY(xData, yData);
                        plotMain.Plot.SetAxisLimits(xData.Min(), xData.Max(), -200, 10);
                        plotMain.Plot.XAxis.TickLabelFormat(x => (x).ToString("G"));
                        plotMain.Refresh();
                    }
                }
            }
        }

        private void btnProcessWDL_Click(object sender, EventArgs e)
        {
            double[] xWDL, yWDL;
            double xMin, xMax;

            xMin = Double.Parse(edWDLXMin.Text);
            xMax = Double.Parse(edWDLXMax.Text);

            // please make sure to perform a measurement first
            // then specify start and end position of WDL filter region

            if (cmbPort.SelectedIndex == 3)
            {
                // process Trasnmission WDL data from the last scan data
                spa.GetTransmissionWDLData(xMin, xMax, out xWDL, out yWDL);

                plotWDL.Plot.Clear();
                plotWDL.Plot.AddSignalXY(xWDL, yWDL);
                plotWDL.Plot.SetAxisLimits(xWDL.Min(), xWDL.Max());
                plotWDL.Refresh();

            }
            else
            {
                // process Reflection WDL data from the last scan data
                spa.GetReflectionWDLData(xMin, xMax, out xWDL, out yWDL);

                plotWDL.Plot.Clear();
                plotWDL.Plot.AddSignalXY(xWDL, yWDL);
                plotWDL.Plot.SetAxisLimits(xWDL.Min(), xWDL.Max());
                plotWDL.Refresh();

            }

                
        }

        private void cmbPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPort.SelectedIndex == 0)
                spa.SetOperationSettingsValue("MeasurementMode", 0);
            else if (cmbPort.SelectedIndex == 1)
                spa.SetOperationSettingsValue("MeasurementMode", 1);
            else if (cmbPort.SelectedIndex == 2)
                spa.SetOperationSettingsValue("MeasurementMode", 2);
            else if (cmbPort.SelectedIndex == 3)
                spa.SetOperationSettingsValue("MeasurementMode", 3);
        }

        private void btnProcessPeaks_Click(object sender, EventArgs e)
        {
            double[] peakList;
            double[] valList;
            double rlValue, ilValue;

            double xMin = Double.Parse(edPeakXMin.Text);
            double xMax = Double.Parse(edPeakXMax.Text);
            double peakThreshold = Double.Parse(edPeakThreshold.Text);
            double peakWidth = Double.Parse(edPeakWidth.Text);
            int maxCount = Int32.Parse(edMaxPeakCount.Text);

            // set the peak search threshold
            spa.SetOperationSettingsValue("PeakThreshold", peakThreshold);
            spa.SetOperationSettingsValue("PeakWidth", peakWidth);


            // test
            spa.ExecutePeakScan(xMin, xMax, 0, maxCount, out peakList, out valList);

            // find up to maxCount peaks from xMin to xMax in the forward direction
            // distance calculated relative to 0
            spa.MeasurePeakDistance(0, xMin, xMax, 0, maxCount, out peakList, out valList);

            plotMain.Plot.Clear(typeof(ScottPlot.Plottable.MarkerPlot));
            lstPeaks.Items.Clear();

            if (peakList == null)
            {
                MessageBox.Show("No peaks found");
                return;
            }

            for(int i = 0; i < peakList.Length; i++)
            {
                // measure the RL across the peak (radius = 0.1 mm)
                spa.MeasureRL(peakList[i] - spa.Settings.RlRange, peakList[i] + spa.Settings.RlRange, out rlValue);

                // measure the IL across the peak (radius = 0.1 mm)
                // note that IL is calculated using an averaging region of ILRange in the setting
                spa.MeasureIL(peakList[i] - spa.Settings.RlRange, peakList[i] + spa.Settings.RlRange, out ilValue);

                string[] row =
                {
                    (i+1).ToString(),
                    peakList[i].ToString("F5"),
                    rlValue.ToString("F4"),
                    ilValue.ToString("F4")
                };

                lstPeaks.Items.Add(new ListViewItem(row));


                var marker = plotMain.Plot.AddMarker(peakList[i], valList[i], MarkerShape.filledCircle, 8, Color.Orange);
                marker.Text = string.Format("{0:0}", i + 1);
                marker.TextFont.Alignment = Alignment.LowerLeft;
                marker.TextFont.Size = 16;

            }

            plotMain.Refresh();
            
        }

        private void btnLoadSettingsFile_Click(object sender, EventArgs e)
        {
            dlgLoadSettings.ShowDialog();

            if (File.Exists(dlgLoadSettings.FileName))
            {
                spa.LoadOperationSettingsFromFile(dlgLoadSettings.FileName);
                UpdateSettingsUI();
            }

            
        }

        private void cmbDistanceRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            double dist = 0;
            Double.TryParse(cmbDistanceRange.Text, out dist);

            if (dist > 0)
                spa.SetOperationSettingsValue("DistanceRange", dist);
        }

        private void btnSaveDSPA_Click(object sender, EventArgs e)
        {
            var fileStatus = dlgSaveDSPA.ShowDialog();

            if (fileStatus == DialogResult.OK)
            {
                spa.SaveDSPAFile(dlgSaveDSPA.FileName);
                MessageBox.Show("Saved DSPA file");
            }

        }

        private void btnUpdateSettings_Click(object sender, EventArgs e)
        {
            UpdateSettings();
            UpdateSettingsUI();
        }

        private void btnTSLCloseShutter_Click(object sender, EventArgs e)
        {
            spa.CloseTSLShutter();
        }

        private void btnTSLOpenShutter_Click(object sender, EventArgs e)
        {
            spa.OpenTSLShutter();
        }

        private void btnExitStandby_Click(object sender, EventArgs e)
        {
            spa.StopScan();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            double[] xData, yData;
            int status = 0;
            double startPos, endPos, distCorrPos;

            if (cmbPort.SelectedIndex == 3)
            {
                // scan and process transmission measurement
                status = spa.GetTransmissionData(out xData, out yData);
                if (status != 0)
                {
                    MessageBox.Show("Error: " + status);
                    return;
                }

                plotMain.Plot.Clear();
                plotMain.Plot.AddSignalXY(xData, yData);
                plotMain.Plot.SetAxisLimits(xData.Min(), xData.Max(), -200, 10);
                plotMain.Plot.XAxis.TickLabelFormat(x => (x).ToString("G"));
                plotMain.Refresh();
            }
            else
            {
                if (cbDispComp.Checked)
                {
                    spa.SetDispersionCompensationRegion(double.Parse(edDispCompX1.Text), double.Parse(edDispCompX2.Text));
                    spa.SetOperationSettingsValue("DispersionCompensation", true);
                }

                if (cbMeasRange.Checked)
                {
                    startPos = double.Parse(edMeasRangeMin.Text);
                    endPos = double.Parse(edMeasRangeMax.Text);

                    if (cbDistCorrPos.Checked)
                    {
                        distCorrPos = double.Parse(edDistCorrPos.Text);

                        // process reflection measurement
                        if (rbFFTA.Checked)
                            status = spa.GetReflectanceDataA(startPos, endPos, distCorrPos, out xData, out yData);
                        else if (rbFFTB.Checked)
                            status = spa.GetReflectanceDataB(startPos, endPos, distCorrPos, out xData, out yData);
                        else
                            status = spa.GetReflectanceData(startPos, endPos, distCorrPos, out xData, out yData);

                    }
                    else
                    {
                        // process reflection measurement
                        if (rbFFTA.Checked)
                            status = spa.GetReflectanceDataA(startPos, endPos, out xData, out yData);
                        else if (rbFFTB.Checked)
                            status = spa.GetReflectanceDataB(startPos, endPos, out xData, out yData);
                        else
                            status = spa.GetReflectanceData(startPos, endPos, out xData, out yData);
                    }

                    
                }
                else
                {
                    if (rbFFTA.Checked)
                        status = spa.GetReflectanceDataA(out xData, out yData);
                    else if (rbFFTB.Checked)
                        status = spa.GetReflectanceDataB(out xData, out yData);
                    else
                        status = spa.GetReflectanceData(out xData, out yData);
                }

                if (status != 0)
                {
                    MessageBox.Show("Error: " + status);
                    return;
                }

                plotMain.Plot.Clear();
                plotMain.Plot.AddSignalXY(xData, yData);
                plotMain.Plot.SetAxisLimits(xData.Min(), xData.Max(), -200, 10);
                plotMain.Plot.XAxis.TickLabelFormat(x => (x).ToString("G"));
                plotMain.Refresh();
            }

            MessageBox.Show("Update finished");
        }
    }
}
