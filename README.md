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
The application is also setup for themeing, light and dark. It uses the theming work I put into [this](https://github.com/AaronAmberman/WPF.Themes) repository. Please check it out for WPF themes that change most of the built in controls' appearance.

## Design Patterns
Uses a simple ServiceLocator pattern along with MVVM for XAML.

![image](https://github.com/AaronAmberman/LTT-WPF-Application/assets/23512394/b6328fa8-3e7e-4e43-843c-0a2ddc5ec497)

![image](https://github.com/AaronAmberman/LTT-WPF-Application/assets/23512394/f444a8b6-c770-4ebb-9ef9-7d410c9b12f8)

![image](https://github.com/AaronAmberman/LTT-WPF-Application/assets/23512394/29cb100b-1e99-43e2-be8e-330bd32f9324)

![image](https://github.com/AaronAmberman/LTT-WPF-Application/assets/23512394/b8aac3c3-43cc-4c52-8ec2-13ceb056ab86)

![image](https://github.com/AaronAmberman/LTT-WPF-Application/assets/23512394/84ee5692-ee56-4118-a409-7d7bbabf2621)

![image](https://github.com/AaronAmberman/LTT-WPF-Application/assets/23512394/1a2b6856-fcbb-4f93-9558-ca3d94665931)

These changes happen **without** needing to restart the application. Just click OK on the settings screen.
