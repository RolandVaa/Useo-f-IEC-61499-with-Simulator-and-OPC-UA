<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="a6921d0e-d45c-4d4a-90a9-31dc538dcc8f" Name="HandshakeAdapter_Proposal" Comment="Adapter Interface" Namespace="Main">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="nxtControl GmbH" Version="0.0" Author="prana" Date="2/8/2021" />
  <InterfaceList>
    <EventInputs>
      <Event Name="E_Data4" Comment="Request from Socket">
        <With Var="Data4" />
      </Event>
      <Event Name="E_Data5">
        <With Var="Data5" />
      </Event>
      <Event Name="E_Data6">
        <With Var="Data6" />
      </Event>
    </EventInputs>
    <EventOutputs>
      <Event Name="E_Data1" Comment="Confirmation from Plug">
        <With Var="Data1" />
      </Event>
      <Event Name="E_Data2">
        <With Var="Data2" />
      </Event>
      <Event Name="E_Data3">
        <With Var="Data3" />
      </Event>
    </EventOutputs>
    <InputVars>
      <VarDeclaration Name="Data4" Type="STRING[60]" Comment="Request Data from Socket" />
      <VarDeclaration Name="Data5" Type="BOOL" />
      <VarDeclaration Name="Data6" Type="BOOL" />
    </InputVars>
    <OutputVars>
      <VarDeclaration Name="Data1" Type="STRING[60]" Comment="Confirmation Data from Plug" />
      <VarDeclaration Name="Data2" Type="BOOL" />
      <VarDeclaration Name="Data3" Type="BOOL" />
    </OutputVars>
  </InterfaceList>
  <Service RightInterface="PLUG" LeftInterface="SOCKET">
    <ServiceSequence Name="request_confirm">
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="E_Data4" Parameters="Data4" />
        <OutputPrimitive Interface="PLUG" Event="E_Data4" Parameters="Data4" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="E_Data1" Parameters="Data1" />
        <OutputPrimitive Interface="SOCKET" Event="E_Data1" Parameters="Data1" />
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