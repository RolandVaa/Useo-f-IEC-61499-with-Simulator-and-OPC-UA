/*
 * Created by EcoStruxure Automation Expert.
 * User: Pranay Jhunjhunwala
 * Date: 23/09/2021
 * Time: 1:11 pm
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #ControlHMI_HMI;

namespace HMI.Main.Symbols.ControlHMI
{

  public class E_ProcessStatusEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public E_ProcessStatusEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_ProcessStatus(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String ProcessStatus
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }


  }

}

namespace HMI.Main.Symbols.ControlHMI
{

  public class E_SEventArgs : System.EventArgs
  {
    public E_SEventArgs()
    {
    }
    private System.Boolean? START_field = null;
    public System.Boolean? START
    {
       get { return START_field; }
       set { START_field = value; }
    }

  }

  public class E_REventArgs : System.EventArgs
  {
    public E_REventArgs()
    {
    }
    private System.Boolean? RESET_field = null;
    public System.Boolean? RESET
    {
       get { return RESET_field; }
       set { RESET_field = value; }
    }

  }

}

namespace HMI.Main.Symbols.ControlHMI
{
  partial class sDefault
  {

    private event EventHandler<HMI.Main.Symbols.ControlHMI.E_ProcessStatusEventArgs> E_ProcessStatus_Fired;

    protected override void OnEndInit()
    {
      if (E_ProcessStatus_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (E_ProcessStatus_Fired != null)
          {
            try
            {
              E_ProcessStatus_Fired(this, new HMI.Main.Symbols.ControlHMI.E_ProcessStatusEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_ProcessStatus_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_E_S(System.Boolean START)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {START});
    }
    public bool FireEvent_E_S(HMI.Main.Symbols.ControlHMI.E_SEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.START.HasValue) _values_[0] = ea.START.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_S(System.Boolean START, bool ignore_START)
    {
      object[] _values_ = new object[1];
      if (!ignore_START) _values_[0] = START;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_R(System.Boolean RESET)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {RESET});
    }
    public bool FireEvent_E_R(HMI.Main.Symbols.ControlHMI.E_REventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.RESET.HasValue) _values_[0] = ea.RESET.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_R(System.Boolean RESET, bool ignore_RESET)
    {
      object[] _values_ = new object[1];
      if (!ignore_RESET) _values_[0] = RESET;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}
#endregion #ControlHMI_HMI;

#endregion Definitions;
