# Modern Apple-Inspired Windows Calculator (v2.0)

[![.NET 10.0](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![Platform](https://img.shields.io/badge/Platform-Windows%2010%20%7C%2011-0078D6?logo=windows&logoColor=white)](https://www.microsoft.com/windows)
[![Design](https://img.shields.io/badge/Design-Apple%20HIG%20%26%20VisionOS-black?logo=apple&logoColor=white)](https://developer.apple.com/design/)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)

A handcrafted, high-precision desktop calculator for Windows built with C# and .NET 10 Windows Forms, designed strictly adhering to **Apple Human Interface Guidelines (HIG)** and **VisionOS Frosted Glassmorphism**.

Originally created by [@legenddohe-coder](https://github.com/legenddohe-coder/calculator) and completely redesigned with modern UI/UX, responsive fluid controls, 8 curated appearance themes, live in-app switcher, and zero emojis or blurry fonts.

---

## Highlights & Features

- **Apple Design & Physical Depth**:
  - Smooth rounded squircle buttons with anti-aliased geometry and active press feedback.
  - Optical centering for vector math glyphs (`+`, `−`, `×`, `÷`, `±`, `⌫`, `⚙`, `✕`).
  - Native Windows 11 DWM title bar color synchronization (caption and text seamlessly blend with the active theme).
  - VisionOS Liquid Glassmorphism with top-rim light reflection arcs.

- **8 Handcrafted Premium Themes**:
  - **Apple Dark**: Authentic macOS/iOS dark slate with vibrant orange accent.
  - **Apple Light**: Clean studio silver with subtle borders and amber accents.
  - **Liquid Glass**: VisionOS-inspired frosted glass aesthetic with cyan accents.
  - **Soft Sakura**: Elegant soft rose pastel with crimson operators.
  - **Midnight OLED**: Deep space pure black with emerald neon indicators.
  - **Nordic Slate**: Cool Scandinavian studio slate with arctic sky blue buttons.
  - **Obsidian Gold**: Luxurious obsidian charcoal with warm champagne gold accents.
  - **Cyber Violet**: Vibrant neon synthwave violet with electric purple highlights.

- **In-App Live Theme Switcher**:
  - Seamless in-app slide-over panel — **no jarring separate OS popup windows**.
  - Dynamic 2-column preview cards with color palette swatches and vector checkmark indicators.
  - Instant live preview and persistent JSON storage (`theme_settings.json`).

- **Calculator Engine**:
  - Immediate chaining arithmetic calculations (`7 + 5 × 2`).
  - Division-by-zero protection.
  - History expression tracker above large formatted result display.
  - Full keyboard numpad integration with keyboard shortcuts.

---

## Keyboard Shortcuts

| Key | Action |
| :--- | :--- |
| `0` - `9` / `Numpad 0` - `Numpad 9` | Input Digits |
| `.` / `Numpad .` | Decimal Point |
| `+`, `-`, `*`, `/` | Arithmetic Operators (`+`, `−`, `×`, `÷`) |
| `Enter` / `=` | Calculate Result |
| `Backspace` | Delete last digit |
| `Esc` | Clear (AC) / Dismiss Themes Overlay |

---

## Quick Start & Running from Source

### Prerequisites
- [.NET 10.0 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) (or higher)
- Windows 10 (1809+) or Windows 11

### Run with .NET CLI:
```powershell
# Clone the repository
git clone https://github.com/legenddohe-coder/calculator.git
cd calculator

# Run the app
dotnet run --project calculator
```

---

## Building a Standalone Release (.exe)

You can build a single-file, self-contained executable that runs on any 64-bit Windows machine **without requiring .NET runtime installed**:

```powershell
# Using the provided publish script:
.\publish.ps1
```

Or manually using the .NET CLI:
```powershell
dotnet publish calculator\calculator.csproj -c Release -r win-x64 --self-contained true /p:PublishSingleFile=true /p:IncludeNativeLibrariesForSelfExtract=true -o ./release
```
The resulting standalone binary will be created in `./release/calculator.exe`.

---

## Project Structure

```text
calculator/
├── .github/
│   └── workflows/
│       └── release.yml        # Automated CI/CD release workflow
├── calculator/
│   ├── calculator.csproj      # .NET 10 WinForms project configuration
│   ├── Form1.cs               # Main calculator logic & event handlers
│   ├── Form1.Designer.cs      # Layout, controls & overlay hierarchy
│   ├── ModernButton.cs        # Apple-style custom button with vector glyphs
│   ├── Theme.cs               # Color definitions for all 8 themes
│   ├── ThemeCardButton.cs     # Theme preview cards with swatches & indicators
│   ├── ThemeManager.cs        # Theme state manager & JSON persistence
│   └── Program.cs             # Application entry point
├── publish.ps1                # One-click portable release builder
├── RELEASE_NOTES.md           # Version release notes
└── README.md                  # Project documentation
```

---

## Credits & Acknowledgments

- **Original Project**: [@legenddohe-coder](https://github.com/legenddohe-coder/calculator)
- **UI/UX Modernization & Redesign**: Inspired by Apple Human Interface Guidelines and VisionOS design language.
- **Contributing**: See [CONTRIBUTING.md](CONTRIBUTING.md) for guidelines on how to contribute.
- **Contributors**: See [CONTRIBUTORS.md](CONTRIBUTORS.md) for the full list of project contributors.

