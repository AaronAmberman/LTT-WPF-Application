# LTT-WPF-Application
## Logged Translated Themed WPF Application
A logged translated themed (light and dark) WPF application template that can make starting a new modern day application very easy. 

### Settings Window
There is already a settings [InternalDialog](https://github.com/AaronAmberman/WPF.InternalDialogs) that can be opened via a button at the top right of the main window. Nuget package available [here](https://www.nuget.org/packages/WPF.InternalDialogs/).

### Logged
You can specify a log path in the settings window. By default the application will log to the path where it is executing but a custom path can be chosen. It uses my [SimpleLogger](https://github.com/AaronAmberman/SimpleLogger) API to manage logging.

### Translated
The application uses [WPF.Translations](https://github.com/AaronAmberman/WPF.Translations) to assist in managing translations. Nuget package avilable [here](https://www.nuget.org/packages/WPF.Translations/). 

### Themed
The application is also setup for themeing, light and dark. It uses the theming work I put into [this](https://github.com/AaronAmberman/WPF.Themes) repository. Please check it out for WPF themes that change most of the built in control's appearance.
