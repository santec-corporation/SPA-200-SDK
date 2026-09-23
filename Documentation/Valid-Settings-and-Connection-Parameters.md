# Valid Settings and Connection Parameters

## Settings INI

### Start Wavelength

```text
LimitMinWave <= StartWave <= LimitMaxWave
```

If invalid, floor `StartWave` to `LimitMinWave`.

### Stop Wavelength

```text
LimitMinWave <= StopWave <= LimitMaxWave
```

If invalid, ceiling `StopWave` to `LimitMaxWave`.

### Wavelength Order

```text
StartWave >= StopWave
```

If invalid, set `StartWave` to `LimitMinWave` and `StopWave` to `LimitMaxWave`.

### Water Absorption Wavelengths

```text
1350 <= StartWave <= 1420
1350 <= StopWave <= 1420
```

- Water Absorption Wavelengths
- If invalid, set to `LimitMinWave` and `LimitMaxWave`.

### Measurement Mode

Valid values:

```text
MeasurementMode: 0, 1, 2, 3
```

| Value | Description |
|---:|---|
| `0` | Port 1 |
| `1` | Port 2 |
| `2` | Unused |
| `3` | IL (Transmission) |

### Refractive Index

```text
DefaultRefractiveIndexValue >= 1
```

If invalid, set to `1`.

### Power

```text
-3 <= Power <= 10
```

If invalid, set to `-3`.

### Gain

Valid values:

```text
Gain: 0, 1, 2, 3, 4
```

| Value | Description |
|---:|---|
| `0` | Auto |
| `1` | 0 dB |
| `2` | 4 dB |
| `3` | 9 dB |
| `4` | 13 dB |

### Wavelength Resolution

```text
WdlResolution: 0 - 10
```

| Value | Resolution |
|---:|---|
| `0` | `w2500fm` |
| `1` | `w5pm` |
| `2` | `w10pm` |
| `3` | `w20pm` |
| `4` | `w40pm` |
| `5` | `w80pm` |
| `6` | `w160pm` |
| `7` | `w320pm` |
| `8` | `w640pm` |
| `9` | `w1281pm` |
| `10` | `w2564pm` |

### Distance Range

Typical values:

```text
30.0m, 70.0m, 250.0m
```

Use `GetDistanceRangeTable` to get the list of available values.

The sweep range must be reduced according to `DistanceRange`:

| Distance Range | Sweep Range |
|---:|---:|
| `30.0m` | `160 nm` |
| `70.0m` | `40 nm` |
| `250.0m` | `10 nm` |

> **Note:** These distances are in free space.

---

## Connection INI

### TSL Communication

Valid communication methods:

- `USB`
- `GPIB`
- `LAN`

### GPIB

If `TSL Communication = GPIB`:

```text
GPIBAddress = 0 - 30
```

### USB

If `TSL Communication = USB`:

```text
USBDeviceID > 0
```

### LAN

If `TSL Communication = LAN`:

- `IP` and `Port` must be valid.

### SPA-200 Device ID

The SPA-200 Device ID is the last 6 digits of the MAC address (see label on instrument).
