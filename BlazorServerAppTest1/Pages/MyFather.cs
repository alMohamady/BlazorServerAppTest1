using Microsoft.AspNetCore.Components;


namespace BlazorServerAppTest1.Pages
{
    public class MyFather : ComponentBase
    {
        [Inject]
        protected NavigationManager navManager { get; set; }

        public string txtName { get; set; } = string.Empty;

        protected void GoToInfoPage()
        {
            navManager.NavigateTo($"/MyPage/MyPageInfo/{txtName}/38");
        }

    }
}
