﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください

namespace MoveFileByInternal
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void From_select_button_ContextCanceled()
        {

        }

        /*
         * FROM選択ボタンクリック時
         * 
         */
        private async void From_select_button_Click(object sender, RoutedEventArgs e)
        {
            var folderPicker = new Windows.Storage.Pickers.FolderPicker();

            // 選択可能な拡張子を追加
            folderPicker.FileTypeFilter.Add("*");

            Windows.Storage.StorageFolder folder = await folderPicker.PickSingleFolderAsync();

            if (folder == null)
            {
                return;
            }

            from_select_textbox.Text = folder.Path.ToString();
        }

        /*
         * TO選択ボタンクリック時
         * 
         */
        private async void To_select_button_Click(object sender, RoutedEventArgs e)
        {
            var folderPicker = new Windows.Storage.Pickers.FolderPicker();

            // 選択可能な拡張子を追加
            folderPicker.FileTypeFilter.Add("*");

            Windows.Storage.StorageFolder folder = await folderPicker.PickSingleFolderAsync();

            if (folder == null)
            {
                return;
            }

            to_select_textbox.Text = folder.Path.ToString();
        }

        /*
         * 転送ボタンクリック時
         * 
         */
        private void Start_button_click(object sender, RoutedEventArgs e)
        {
            // 転送ボタンを非活性
            start_button.IsEnabled = true;
            // validate

            // エラーの場合、エラーメッセージを表示し、転送ボタンを活性化する

            // fromディレクトリを回して、フォルダorファイルを１つ１つ取得

            // 対象のフォルダorファイルを転送先にファイルを転送する

            // 転送したファイルをログに出力

            // 指定の秒数スリープする
            SleepAsync(3);

            // 全ての終了後、転送ボタンを活性化する
            start_button.IsEnabled = false;

        }

        private async void SleepAsync(int minites)
        {
            await Task.Delay(minites * 1000);
        }
    }

}
