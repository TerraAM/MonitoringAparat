//using Microsoft.JSInterop;
//using System.Threading;
//namespace MonitoringAparat.Components
//{
//    public class Time
//    {
//        public async void UpdateTime()
//        {
//            string tim;
//            while (true)
//            {
//                tim = await JSRuntime.InvokeVoidAsync<string>("getCurrentTime");
//                StateHasChanged();
//                await Task.Delay(1000);
//            }
//        }

//    }

//}
