<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="894b538e-dc70-4aec-b2b2-008b155bbda8" Name="Adapter_hmi" Comment="Adapter Interface" Namespace="Main">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.0" Author="Pranay Jhunjhunwala" Date="23/09/2021" />
  <InterfaceList>
    <EventInputs>
      <Event Name="E_P" Comment="Request from Socket">
        <With Var="PROCESS" />
      </Event>
    </EventInputs>
    <EventOutputs>
      <Event Name="E_S" Comment="Confirmation from Plug">
        <With Var="START" />
      </Event>
      <Event Name="E_R" Comment="Indication from Plug">
        <With Var="RESET" />
      </Event>
    </EventOutputs>
    <InputVars>
      <VarDeclaration Name="PROCESS" Type="STRING[60]" Comment="Request Data from Socket" />
    </InputVars>
    <OutputVars>
      <VarDeclaration Name="START" Type="BOOL" Comment="Confirmation Data from Plug" />
      <VarDeclaration Name="RESET" Type="BOOL" Comment="Indication Data from Plug" />
    </OutputVars>
  </InterfaceList>
  <Service RightInterface="PLUG" LeftInterface="SOCKET">
    <ServiceSequence Name="request_confirm">
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="E_P" Parameters="PROCESS" />
        <OutputPrimitive Interface="PLUG" Event="E_P" Parameters="PROCESS" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="E_S" Parameters="START" />
        <OutputPrimitive Interface="SOCKET" Event="E_S" Parameters="START" />
      </ServiceTransaction>
    </ServiceSequence>
    <ServiceSequence Name="indication_response">
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="E_R" Parameters="RESET" />
        <OutputPrimitive Interface="SOCKET" Event="E_R" Parameters="RESET" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="RSP" Parameters="RSPD" />
        <OutputPrimitive Interface="PLUG" Event="RSP" Parameters="RSPD" />
      </ServiceTransaction>
    </ServiceSequence>
  </Service>
</AdapterType>