# KDCLLC.Common.Logging.EntLib60

This project is designed to provide a Console Trace Listener 
to Microsoft Enterprise Logging 6.0 Logging.

## Basic App/Web.config file:
```
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <configSections>
    <section name="loggingConfiguration" type="Microsoft.Practices.EnterpriseLibrary.Logging.Configuration.LoggingSettings, Microsoft.Practices.EnterpriseLibrary.Logging" />
    <sectionGroup name="common">
      <section name="logging" type="Common.Logging.ConfigurationSectionHandler, Common.Logging" />
    </sectionGroup>
  </configSections>
  <common>
    <logging>
      <factoryAdapter type="Common.Logging.EntLib.EntLibLoggerFactoryAdapter, Common.Logging.EntLib60"/>
    </logging>
  </common>
  <loggingConfiguration name="" tracingEnabled="true" defaultCategory="General">
    <listeners>
      <add type="KDCLLC.Common.Logging.EntLib60.ConsoleTraceListener, KDCLLC.Common.Logging.EntLib60" listenerDataType="Microsoft.Practices.EnterpriseLibrary.Logging.Configuration.CustomTraceListenerData, Microsoft.Practices.EnterpriseLibrary.Logging" formatter="Times Formatter" name="Console Listener" />
    </listeners>
    <formatters>
      <add template="{message}" type="Microsoft.Practices.EnterpriseLibrary.Logging.Formatters.TextFormatter, Microsoft.Practices.EnterpriseLibrary.Logging" name="Times Formatter" />
      <add type="Microsoft.Practices.EnterpriseLibrary.Logging.Formatters.TextFormatter, Microsoft.Practices.EnterpriseLibrary.Logging" template="{timestamp(local:[MM/dd/yyyy HH:mm:ss.fff])} : ({title}) {message}" name="Simple Formatter" />
    </formatters>
    <categorySources>
      <add switchValue="All" name="General">
        <listeners>
          <add name="Console Listener" />
        </listeners>
      </add>
    </categorySources>
    <specialSources>
      <allEvents switchValue="All" name="All Events" />
      <notProcessed switchValue="All" name="Unprocessed Category">
        <listeners>
          <add name="Console Listener" />
        </listeners>
      </notProcessed>
      <errors switchValue="All" name="Logging Errors &amp; Warnings">
        <listeners>
          <add name="Console Listener" />
        </listeners>
      </errors>
    </specialSources>
  </loggingConfiguration>

</configuration>

```
