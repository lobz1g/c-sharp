using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FindBox.MyControl
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class TestControl : UserControl
    {
        public TestControl()
        {
            InitializeComponent();
            searchWord.TextChanged += searchWord_TextChanged;
        }

        private void searchBut_Click(object sender, RoutedEventArgs e)
        {

        }

        private void searchWord_TextChanged(object sender, TextChangedEventArgs e)
        {
            Paragraph par = new Paragraph();
            FlowDocument flow_doc = new FlowDocument();
            TextRange my_Range = new TextRange(mainTextBox.Document.ContentStart, mainTextBox.Document.ContentEnd);
            string data = my_Range.Text;
            int start = 0;
            int at = 0;
            int count = 0;
            string tmpSearchText;
            string tmpMainText;
            tmpMainText = my_Range.Text;
            tmpSearchText = searchWord.Text;

            int end = tmpMainText.Length;
            int j = 0;
            while ((start <= end) && (at > -1) && tmpSearchText.Length != 0)
            {
                count = end - start;
                if (reg.IsChecked == false) at = tmpMainText.ToLower().IndexOf(tmpSearchText.ToLower(), start, count);
                else at = tmpMainText.IndexOf(tmpSearchText, start, count);

                if (at == -1)
                {
                    if (j == 0) break;
                    else
                    {
                        par.Inlines.Add(tmpMainText.Substring(start, count - 2));
                        break;
                    }
                }
                if (word.IsChecked == true)
                {
                    Span span = new Span();
                    if ((at == 0 || tmpMainText.Substring(at - 1, 1) == " ") && (tmpMainText.Substring(at + tmpSearchText.Length, 1) == "\r" || tmpMainText.Substring(at + tmpSearchText.Length, 1) == " "))
                    {
                        span.Background = Brushes.LightGreen;
                        string tmpColor = tmpMainText.Substring(at, tmpSearchText.Length);
                        span.Inlines.Add(tmpColor);
                        par.Inlines.Add(tmpMainText.Substring(start, at - start));
                        par.Inlines.Add(span);
                    }
                    else
                    {
                        par.Inlines.Add(tmpMainText.Substring(start, at - start + tmpSearchText.Length));
                    }
                    start = at + tmpSearchText.Length;
                    j++;
                }
                else
                {
                    Span span = new Span();
                    span.Background = Brushes.LightGreen;
                    string tmpColor = tmpMainText.Substring(at, tmpSearchText.Length);
                    span.Inlines.Add(tmpColor);
                    par.Inlines.Add(tmpMainText.Substring(start, at - start));
                    par.Inlines.Add(span);
                    start = at + tmpSearchText.Length;
                    j++;
                }
            }

            if (j > 0)
            {
                flow_doc.Blocks.Add(par);
                mainTextBox.Document = flow_doc;
            }
            else
            {
                Span span = new Span();
                span.Background = Brushes.White;
                span.Inlines.Add(data);
                Paragraph tmpPar = new Paragraph();
                tmpPar.Inlines.Add(span);
                flow_doc.Blocks.Add(tmpPar);
                mainTextBox.Document = flow_doc;
            }
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}
