using Cysharp.Threading.Tasks;
using GameFrameX.Fsm.Runtime;
using GameFrameX.Procedure.Runtime;

namespace Unity.Startup.Procedure
{
    /// <summary>
    /// 启动游戏
    /// </summary>
    public class ProcedureLauncherState : ProcedureBase
    {
        protected override void OnEnter(IFsm<IProcedureManager> procedureOwner)
        {
#if ENABLE_UI_FAIRYGUI
            FairyGUI.UIObjectFactory.SetLoaderExtension(typeof(FairyGuiExtensionLoader));
#endif
            base.OnEnter(procedureOwner);
            LauncherUIHandler.Start();
            Start(procedureOwner);
        }

        private async void Start(IFsm<IProcedureManager> procedureOwner)
        {
            AppConst.UseLocalHost = false;
            await UniTask.NextFrame();
            ChangeState<ProcedureGetGlobalInfoState>(procedureOwner);
        }
    }
}