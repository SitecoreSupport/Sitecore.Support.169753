namespace Sitecore.Support.Shell.Applications.ContentEditor
{
  using System;
  public class Checkbox : Sitecore.Shell.Applications.ContentEditor.Checkbox
  {
    protected override void OnInit(EventArgs e)
    {
      #region Added code
      this.Disabled = this.ReadOnly; 
      #endregion
      base.OnInit(e);
    }
  }
}