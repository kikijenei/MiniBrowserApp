# MiniBrowserApp / SafeNavigationApp


This is a C# Windows Forms application that simulates a basic web navigation tool with keyword filtering. It was created as a university project and includes SQLite integration for storing blocked keywords.

The app allows users to enter a URL, navigate through pages, and automatically blocks pages containing specific keywords. All actions are logged to a local file.

## Main Features

- Web navigation using `WebBrowser` control
- SQLite integration to store and manage blocked keywords
- URL filtering based on saved keywords
- Logging all user navigation actions (`log.txt`)
- Menu options to add, delete, and view keywords
- Simple Windows Forms GUI

## Technologies/Packages Used

- C# (.NET Framework)
- Windows Forms
- System.Data.SQLite
- LINQ & async tasks
- Trace logging (to file)

## Status

This is a small educational project developed for experimentation with C# GUI design, local databases, and basic browser functionality.
