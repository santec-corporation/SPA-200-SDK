# Valid Settings and Connection Parameters

## Settings INI

### Wavelength Settings

#### `StartWave`

```text
LimitMinWave <= StartWave <= LimitMaxWave
```

- If invalid, `StartWave` is floored to `LimitMinWave`.

#### `StopWave`

```text
LimitMinWave <= StopWave <= LimitMaxWave
```

- If invalid, `StopWave` is ceiled to `LimitMaxWave`.

#### Start / Stop Wavelength Relationship

```text
StartWave >= StopWave
```

- If not valid, set:
  - `StartWave` = `LimitMinWave`
  - `StopWave` = `LimitMaxWave`

### Water Absorption Wavelengths

```text
1350 <= StartWave <= 1420
1350 <= StopWave <= 1420
```

- Water Absorption Wavelengths
- If invalid, set to `LimitMinWave` and `LimitMaxWave`.

### Measurement Mode

| Value | Description |
|---:|---|
| `0` | Port 1 |
| `1` | Port 2 |
| `2` | Unused |
| `3` | IL (Transmission) |

### Default Refractive Index

```text
DefaultRefractiveIndexValue >= 1
```

- If invalid, set to `1`.

### Power

```text
-3 <= Power <= 10
```

- If invalid, set to `-3`.

### Gain

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

```text
DistanceRange: 30.0m, 70.0m, 250.0m (typical)
```

Use `GetDistanceRangeTable` to get the list of available values.

The sweep range must be reduced with `DistanceRange`:

| Distance Range | Sweep Range |
|---:|---:|
| `30.0 m` | `160 nm` |
| `70.0 m` | `40 nm` |
| `250.0 m` | `10 nm` |

> **Note:** These distances are in free space.

---

## Connection INI

### TSL Communication

Supported communication methods:

- `USB`
- `GPIB`
- `LAN`

If `TSL Communication = GPIB`:

```text
GPIBAddress = 0 - 30
```

If `TSL Communication = USB`:

```text
USBDeviceID > 0
```

If `TSL Communication = LAN`:

- `IP` and `Port` must be valid.

### SPA-200 Device ID

The SPA-200 Device ID is the last 6 digits of the MAC address (see label on instrument).
