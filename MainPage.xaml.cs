using net.sf.saxon.s9api;

namespace SaxonHEMauiNet7Test3;

public partial class MainPage : ContentPage
{

	private static readonly Processor processor = new(true);

	public MainPage()
	{
		InitializeComponent();
		HWLabel.Text += $" Saxon {processor.getSaxonEdition()} {processor.getSaxonProductVersion()}";
	}

    private void CurrentDateTime_Clicked(object sender, EventArgs e)
    {
		CurrentDateTime.Text = $"Clicked at {processor.newXPathCompiler().evaluateSingle("current-dateTime()", null).getStringValue()}";
    }
}

