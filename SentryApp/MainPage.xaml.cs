namespace SentryApp;

public sealed partial class MainPage : Page
{
	public MainPage()
	{
		this.InitializeComponent();
	}

	private void SendMessage_Click(object sender, RoutedEventArgs e)
	{
		SentrySdk.CaptureMessage("Hello Sentry");

		try
		{
			throw new InvalidOperationException("This is a test exception");
		}
		catch (Exception err)
		{
			SentrySdk.CaptureException(err);
		}
	}
}
