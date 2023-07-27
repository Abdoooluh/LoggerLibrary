# LoggerLibrary
A library built up on Serilog package that allows easy integration of a custom logger into any asp.NET core application. The library provides a static class MyLogger, which has 6 methods that can be used to log a string message at desired severity level





- MyLogger.logVerbose(string message)				(level 1)

- MyLogger.logDebug(string message)         (level 2)

- MyLogger.logInfo(string message)          (level 3)

- MyLogger.logWarning(string message)       (level 4)

- MyLogger.logError(string message)         (level 5)

- MyLogger.logFatal(string message)         (level 6)

# Setup

The library takes starting configuration from the executing app's appsettings.json file.

A sample "appsettings.json" file is provided with the Library's code (this file will NOT be used, but calling app's own "appsettings.json" will be)
