//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Tizen.NUI.Xaml.XamlResourceIdAttribute("NUIKioskPoster.src.carouselView.CarouselView.xaml", "src/carouselView/CarouselView.xaml", typeof(global::NUIKioskPoster.CarouselView))]

namespace NUIKioskPoster {
    
    
    [Tizen.NUI.Xaml.XamlFilePathAttribute("src\\carouselView\\CarouselView.xaml")]
    [Tizen.NUI.Xaml.XamlCompilationAttribute(global::Tizen.NUI.Xaml.XamlCompilationOptions.Compile)]
    public partial class CarouselView : global::Tizen.NUI.BaseComponents.View {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.24.0")]
        public global::NUIKioskPoster.ImageSizeModel ImageSizeModel;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.24.0")]
        public global::Tizen.NUI.BaseComponents.VisualView gradientBG;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.24.0")]
        public global::Tizen.NUI.BaseComponents.View container;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.24.0")]
        public global::NUIKioskPoster.SummaryView popupInfoView;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Tizen.NUI.Xaml.Build.Tasks.XamlG", "1.0.24.0")]
        private void InitializeComponent() {
            global::Tizen.NUI.EXaml.EXamlExtensions.LoadFromEXamlByRelativePath(this, GetEXamlPath());
            ImageSizeModel = global::Tizen.NUI.Binding.NameScopeExtensions.FindByName<global::NUIKioskPoster.ImageSizeModel>(this, "ImageSizeModel");
            gradientBG = global::Tizen.NUI.Binding.NameScopeExtensions.FindByName<global::Tizen.NUI.BaseComponents.VisualView>(this, "gradientBG");
            container = global::Tizen.NUI.Binding.NameScopeExtensions.FindByName<global::Tizen.NUI.BaseComponents.View>(this, "container");
            popupInfoView = global::Tizen.NUI.Binding.NameScopeExtensions.FindByName<global::NUIKioskPoster.SummaryView>(this, "popupInfoView");
        }
        
        private string GetEXamlPath() {
            return default(string);
        }
    }
}