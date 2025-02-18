using System.Collections.Generic;
using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Models;
using MessageBox.Avalonia.Views;

namespace MessageBox.Avalonia.ViewModels
{
    public class MsBoxCustomViewModel : AbstractMsBoxViewModel
    {
        private readonly MsBoxCustomWindow _window;


        public MsBoxCustomViewModel(MsCustomParams @params, MsBoxCustomWindow msBoxCustomWindow) : base(@params,
            @params.Icon, @params.BitmapIcon)
        {
            ContentMessage = @params.ContentMessage;
            _window = msBoxCustomWindow;
            ButtonDefinitions = @params.ButtonDefinitions;
        }

        public IEnumerable<ButtonDefinition> ButtonDefinitions { get; }
        public string ContentMessage { get; }

        public void ButtonClick(string parameter)
        {
            foreach (var bd in ButtonDefinitions)
            {
                if (!parameter.Equals(bd.Name)) continue;
                _window.ButtonResult = bd.Name;
                break;
            }

            _window.Close();
        }
    }
}