//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Tizen.NUI.Xaml.XamlResourceIdAttribute("NUIKioskPoster.src.MainView.xaml", "src/MainView.xaml", typeof(global::NUIKioskPoster.MainView))]

namespace NUIKioskPoster {
    
    
    [Tizen.NUI.Xaml.XamlFilePathAttribute("src\\MainView.xaml")]
    [Tizen.NUI.Xaml.XamlCompilationAttribute(global::Tizen.NUI.Xaml.XamlCompilationOptions.Compile)]
    public partial class MainView : global::Tizen.NUI.GaussianBlurView {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.24.0")]
        public global::NUIKioskPoster.CarouselView carouselView;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.24.0")]
        public global::Tizen.NUI.Components.Pagination pagination;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.24.0")]
        private void InitializeComponent() {
            global::Tizen.NUI.EXaml.EXamlExtensions.LoadFromEXamlByRelativePath(this, GetEXamlPath());
            carouselView = global::Tizen.NUI.Binding.NameScopeExtensions.FindByName<global::NUIKioskPoster.CarouselView>(this, "carouselView");
            pagination = global::Tizen.NUI.Binding.NameScopeExtensions.FindByName<global::Tizen.NUI.Components.Pagination>(this, "pagination");
        }
        
        private string GetEXamlPath() {
            return default(string);
        }
    }
}