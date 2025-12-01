/*
 * Created by EcoStruxure Automation Expert.
 * User: Pranay Jhunjhunwala
 * Date: 22/06/2021
 * Time: 12:31 pm
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #CAT1_HMI;

namespace HMI.Main.Symbols.CAT1
{

  public class e_bool_inEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public e_bool_inEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_hello(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? hello
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

  public class e_int_inEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public e_int_inEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_hello_int(ref System.Int16 value)
    {
      if (accessorService == null)
        return false;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Int16) var;
      return ret;
    }

    public System.Int16? hello_int
    { get {
      if (accessorService == null)
        return null;
      System.Int64 var = 0;
      bool ret = accessorService.GetInt64Value(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Int16) var;
    }  }


  }

}

namespace HMI.Main.Symbols.CAT1
{

  public class e_bool_outEventArgs : System.EventArgs
  {
    public e_bool_outEventArgs()
    {
    }
    private System.Boolean? out_field = null;
    public System.Boolean? @out
    {
       get { return out_field; }
       set { out_field = value; }
    }

  }

  public class e_int_outEventArgs : System.EventArgs
  {
    public e_int_outEventArgs()
    {
    }
    private System.Int16? out_int_field = null;
    public System.Int16? out_int
    {
       get { return out_int_field; }
       set { out_int_field = value; }
    }

  }

}

namespace HMI.Main.Symbols.CAT1
{
  partial class sDefault
  {

    private event EventHandler<HMI.Main.Symbols.CAT1.e_bool_inEventArgs> e_bool_in_Fired;

    private event EventHandler<HMI.Main.Symbols.CAT1.e_int_inEventArgs> e_int_in_Fired;

    protected override void OnEndInit()
    {
      if (e_bool_in_Fired != null)
        AttachEventInput(0);
      if (e_int_in_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (e_bool_in_Fired != null)
          {
            try
            {
              e_bool_in_Fired(this, new HMI.Main.Symbols.CAT1.e_bool_inEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","e_bool_in_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (e_int_in_Fired != null)
          {
            try
            {
              e_int_in_Fired(this, new HMI.Main.Symbols.CAT1.e_int_inEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","e_int_in_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_e_bool_out(System.Boolean @out)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {@out});
    }
    public bool FireEvent_e_bool_out(HMI.Main.Symbols.CAT1.e_bool_outEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.@out.HasValue) _values_[0] = ea.@out.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_e_bool_out(System.Boolean @out, bool ignore_out)
    {
      object[] _values_ = new object[1];
      if (!ignore_out) _values_[0] = @out;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_e_int_out(System.Int16 out_int)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {out_int});
    }
    public bool FireEvent_e_int_out(HMI.Main.Symbols.CAT1.e_int_outEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.out_int.HasValue) _values_[0] = ea.out_int.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_e_int_out(System.Int16 out_int, bool ignore_out_int)
    {
      object[] _values_ = new object[1];
      if (!ignore_out_int) _values_[0] = out_int;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}
#endregion #CAT1_HMI;

#endregion Definitions;
