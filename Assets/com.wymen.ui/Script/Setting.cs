using UnityEngine;
namespace UIFramework
{
    public class Setting : BasePanel
    {
        public void OnClickReturnButton()
        {
            UIManager.Instance.PopPanel();
        }
    }
}
