/*
 * Created by EcoStruxure Automation Expert.
 * User: Pranay Jhunjhunwala
 * Date: 26/10/2022
 * Time: 1:44 pm
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #CAT_Robotino_HMI;

namespace HMI.Main.Symbols.CAT_Robotino
{

  public class E_DockEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public E_DockEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_DockToEnas(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? DockToEnas
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

  public class E_RunConvEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public E_RunConvEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_RunConveyor(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? RunConveyor
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

  public class E_NewCupEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public E_NewCupEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_MakeNewCup(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? MakeNewCup
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

}

namespace HMI.Main.Symbols.CAT_Robotino
{

  public class DocEventArgs : System.EventArgs
  {
    public DocEventArgs()
    {
    }
    private System.Boolean? DockingBool_field = null;
    public System.Boolean? DockingBool
    {
       get { return DockingBool_field; }
       set { DockingBool_field = value; }
    }

  }

  public class E_Cnv1EventArgs : System.EventArgs
  {
    public E_Cnv1EventArgs()
    {
    }
    private System.Boolean? CNV1_field = null;
    public System.Boolean? CNV1
    {
       get { return CNV1_field; }
       set { CNV1_field = value; }
    }

  }

  public class E_SenRoboEventArgs : System.EventArgs
  {
    public E_SenRoboEventArgs()
    {
    }
    private System.Boolean? SensorRobotino_field = null;
    public System.Boolean? SensorRobotino
    {
       get { return SensorRobotino_field; }
       set { SensorRobotino_field = value; }
    }

  }

}

namespace HMI.Main.Symbols.CAT_Robotino
{
  partial class sDefault
  {

    private event EventHandler<HMI.Main.Symbols.CAT_Robotino.E_DockEventArgs> E_Dock_Fired;

    private event EventHandler<HMI.Main.Symbols.CAT_Robotino.E_RunConvEventArgs> E_RunConv_Fired;

    private event EventHandler<HMI.Main.Symbols.CAT_Robotino.E_NewCupEventArgs> E_NewCup_Fired;

    protected override void OnEndInit()
    {
      if (E_Dock_Fired != null)
        AttachEventInput(0);
      if (E_RunConv_Fired != null)
        AttachEventInput(1);
      if (E_NewCup_Fired != null)
        AttachEventInput(2);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (E_Dock_Fired != null)
          {
            try
            {
              E_Dock_Fired(this, new HMI.Main.Symbols.CAT_Robotino.E_DockEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_Dock_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (E_RunConv_Fired != null)
          {
            try
            {
              E_RunConv_Fired(this, new HMI.Main.Symbols.CAT_Robotino.E_RunConvEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_RunConv_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 2:
          if (E_NewCup_Fired != null)
          {
            try
            {
              E_NewCup_Fired(this, new HMI.Main.Symbols.CAT_Robotino.E_NewCupEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","E_NewCup_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_Doc(System.Boolean DockingBool)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {DockingBool});
    }
    public bool FireEvent_Doc(HMI.Main.Symbols.CAT_Robotino.DocEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.DockingBool.HasValue) _values_[0] = ea.DockingBool.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_Doc(System.Boolean DockingBool, bool ignore_DockingBool)
    {
      object[] _values_ = new object[1];
      if (!ignore_DockingBool) _values_[0] = DockingBool;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_E_Cnv1(System.Boolean CNV1)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {CNV1});
    }
    public bool FireEvent_E_Cnv1(HMI.Main.Symbols.CAT_Robotino.E_Cnv1EventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.CNV1.HasValue) _values_[0] = ea.CNV1.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_Cnv1(System.Boolean CNV1, bool ignore_CNV1)
    {
      object[] _values_ = new object[1];
      if (!ignore_CNV1) _values_[0] = CNV1;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_E_SenRobo(System.Boolean SensorRobotino)
    {
      return ((IHMIAccessorOutput)this).FireEvent(2, new object[] {SensorRobotino});
    }
    public bool FireEvent_E_SenRobo(HMI.Main.Symbols.CAT_Robotino.E_SenRoboEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.SensorRobotino.HasValue) _values_[0] = ea.SensorRobotino.Value;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }
    public bool FireEvent_E_SenRobo(System.Boolean SensorRobotino, bool ignore_SensorRobotino)
    {
      object[] _values_ = new object[1];
      if (!ignore_SensorRobotino) _values_[0] = SensorRobotino;
      return ((IHMIAccessorOutput)this).FireEvent(2, _values_);
    }

  }
}
#endregion #CAT_Robotino_HMI;

#endregion Definitions;
