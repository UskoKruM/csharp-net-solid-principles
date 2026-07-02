namespace SolidPrinciples.P01_SingleResponsibility;

public class InvoiceService_Legacy
{
    public void CreateInvoice()
    {
        Console.WriteLine("Factura creada");
    }

    public void SaveToDatabase()
    {
        Console.WriteLine("Factura guardada en base de datos");
    }

    public void SendEmail()
    {
        Console.WriteLine("Correo enviado al cliente");
    }
}

// ----------------------------------------------------------------------------------

public class InvoiceService
{
    public void CreateInvoice()
    {
        Console.WriteLine("Factura creada");
    }
}

public class InvoiceRepository
{
    public void Save()
    {
        Console.WriteLine("Factura guardada en base de datos");
    }
}

public class EmailService
{
    public void Send()
    {
        Console.WriteLine("Correo enviado al cliente");
    }
}