<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="d2a2c5ca-301c-4337-ab80-2686afb02c4b" Comment="Adapter Interface" Name="Adapter_Handshake" Namespace="Main">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="nxtControl GmbH" Version="0.0" Author="prana" Date="11/2/2020" />
  <InterfaceList>
    <EventInputs>
      <Event Name="E_Data1">
        <With Var="Data1" />
      </Event>
      <Event Name="E_Data2">
        <With Var="Data2" />
      </Event>
      <Event Name="Reset_I" />
    </EventInputs>
    <EventOutputs>
      <Event Name="E_Data3">
        <With Var="Data3" />
      </Event>
      <Event Name="E_Data4">
        <With Var="Data4" />
      </Event>
      <Event Name="Reset_O" />
    </EventOutputs>
    <InputVars>
      <VarDeclaration Name="Data1" Type="STRING[60]" />
      <VarDeclaration Name="Data2" Type="STRING[60]" />
    </InputVars>
    <OutputVars>
      <VarDeclaration Name="Data3" Type="STRING[60]" />
      <VarDeclaration Name="Data4" Type="STRING[60]" />
    </OutputVars>
  </InterfaceList>
  <Service RightInterface="PLUG" LeftInterface="SOCKET">
    <ServiceSequence Name="request_confirm">
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="REQ" Parameters="REQD" />
        <OutputPrimitive Interface="PLUG" Event="REQ" Parameters="REQD" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="CNF" Parameters="CNFD" />
        <OutputPrimitive Interface="SOCKET" Event="CNF" Parameters="CNFD" />
      </ServiceTransaction>
    </ServiceSequence>
    <ServiceSequence Name="indication_response">
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="IND" Parameters="INDD" />
        <OutputPrimitive Interface="SOCKET" Event="IND" Parameters="INDD" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="RSP" Parameters="RSPD" />
        <OutputPrimitive Interface="PLUG" Event="RSP" Parameters="RSPD" />
      </ServiceTransaction>
    </ServiceSequence>
  </Service>
</AdapterType>