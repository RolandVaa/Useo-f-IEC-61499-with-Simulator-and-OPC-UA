/*
 * Created by EcoStruxure Automation Expert.
 * User: prana
 * Date: 16/08/2021
 * Time: 11:06 am
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #CAT_Conveyor_1_HMI;

namespace HMI.Main.Symbols.CAT_Conveyor_1
{

  public class REQEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public REQEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_C_Drive(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? C_Drive
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_C_Drive_Cur(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? C_Drive_Cur
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

}

namespace HMI.Main.Symbols.CAT_Conveyor_1
{

  public class CNFEventArgs : System.EventArgs
  {
    public CNFEventArgs()
    {
    }
    private System.Boolean? C_Sensor_field = null;
    public System.Boolean? C_Sensor
    {
       get { return C_Sensor_field; }
       set { C_Sensor_field = value; }
    }

  }

}

namespace HMI.Main.Symbols.CAT_Conveyor_1
{
  partial class sDefault
  {

    private event EventHandler<HMI.Main.Symbols.CAT_Conveyor_1.REQEventArgs> REQ_Fired;

    protected override void OnEndInit()
    {
      if (REQ_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_Fired != null)
          {
            try
            {
              REQ_Fired(this, new HMI.Main.Symbols.CAT_Conveyor_1.REQEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF(System.Boolean C_Sensor)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {C_Sensor});
    }
    public bool FireEvent_CNF(HMI.Main.Symbols.CAT_Conveyor_1.CNFEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.C_Sensor.HasValue) _values_[0] = ea.C_Sensor.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF(System.Boolean C_Sensor, bool ignore_C_Sensor)
    {
      object[] _values_ = new object[1];
      if (!ignore_C_Sensor) _values_[0] = C_Sensor;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #CAT_Conveyor_1_HMI;

#endregion Definitions;
