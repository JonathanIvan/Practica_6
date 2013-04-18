using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBtnFacturaClicked (object sender, EventArgs e)
	{
		double Produ1=double.Parse(this.txtProducto1.Text);
		double Produ2=double.Parse(this.txtProducto2.Text);
		double Produ3=double.Parse(this.txtProducto3.Text);
		double restSubtotal=Produ1+Produ2+Produ3;
		double restIva=restSubtotal*0.16;
		double restTotal=restIva+restSubtotal;

		this.txtSubtotal.Text=restSubtotal.ToString();
		this.txtIva.Text=restIva.ToString();
		this.txtTotal.Text=restTotal.ToString();

	}

	protected void OnBtnLimpiarClicked (object sender, EventArgs e)
	{
		this.txtProducto1.Text="";
		this.txtProducto2.Text="";
		this.txtProducto3.Text="";
		this.txtSubtotal.Text="";
		this.txtIva.Text="";
		this.txtTotal.Text="";
	}
}
