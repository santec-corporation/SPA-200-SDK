# Valid Settings and Connection Parameters

## Settings INI

### Start Wavelength

- Valid range: `LimitMinWave <= StartWave <= LimitMaxWave`
- If invalid, floor `StartWave` to `LimitMinWave`.

### Stop Wavelength

- Valid range: `LimitMinWave <= StopWave <= LimitMaxWave`
- If invalid, ceiling `StopWave` to `LimitMaxWave`.

### Wavelength Order

- Valid condition: `StartWave >= StopWave`
- If invalid, set:
  - `StartWave = LimitMinWave`
  - `StopWave = LimitMaxWave`

### Water Absorption Wavelengths

- Valid range:
  - `1350 <= StartWave <= 1420`
  - `1350 <= StopWave <= 1420`
- If invalid, set `StartWave` to `LimitMinWave` and `StopWave` to `LimitMaxWave`.

### Measurement Mode

Valid values:

| Value | Description |
|---:|---|
| `0` | Port 1 |
| `1` | Port 2 |
| `3` | Port 12 (SPA-100 only) |
| `4` | IL (Transmission) (SPA-100/SPA-110 only) |

> Note: The source lists `MeasurementMode` as `0, 1, 2, 3`, while the descriptions include values `0, 1, 3, 4`.

### Refractive Index

- Valid condition: `DefaultRefractiveIndexValue >= 1`
- If invalid, set to `1`.

### Average Count

- Valid condition: `AverageCount >= 1`
- If invalid, set to `1`.

### Power

- Valid range: `-3 <= Power <= 10`
- If invalid, set to `-3`.

### Gain

Valid values:

| Value | Description |
|---:|---|
| `0` | Auto |
| `1` | 0 dB |
| `2` | 4 dB |
| `3` | 9 dB |
| `4` | 13 dB |

---

## Connection INI

### TSL Communication

Valid communication methods:

- `USB`
- `GPIB`
- `LAN`

### GPIB

If `TSL Communication = GPIB`:

- `GPIBAddress = 0 - 30`

### USB

If `TSL Communication = USB`:

- `USBDeviceID > 0`

### LAN

If `TSL Communication = LAN`:

- `IP` and `Port` must be valid.

### SPA Device ID

- The SPA Device ID must follow the format `Dev#`, where `# > 1`.

### SPA-200 IP Address

For SPA-200, the SPA IP address must be the `xxxxxx` value from the `rp-xxxxxx.local` address shown on the instrument sticker.

### Supported Device Identifiers

```text
w2500fm
w5pm
w10pm
w20pm
w40pm
w80pm
w160pm
w320pm
w640pm
w1281pm
w2564pm
```
