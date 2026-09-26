public static class Tipos {
    
    public struct tMaterial {

        public int Codigo;
        
        public string Descripcion;
        
        public string Precio;
    }
    
    public struct tCliente {
        
        public long Codigo;
        
        public string Nombre;
        
        public string NIF;
        
        public string Direccion;
        
        public string Localidad;
        
        public string CodPostal;
        
        public string Destino;
        
        public string Telefono;
    }
    
    public struct tProveedor {
        
        public int Codigo;
        
        public string Nombre;
        
        public string NIF;
        
        public string Direccion;
        
        public string Localidad;
        
        public string CodPostal;
        
        public string Telefono;
    }
    
    public struct tDetalle {
        
        public long Cod_Cli;
        
        public string Nombre;
        
        public string NIF;
        
        public string Direccion;
        
        public string Localidad;
        
        public string CodPostal;
        
        public string Destino;
        
        public string Descripcion;
        
        public double Precio;

        public double Unidades;
        
        public System.DateTime Fecha;
        
        public int Numero;
        
        public int Cod_Mat;

    }
    
    public struct tFacturaVentas {
        
        public long Cod_Cli;
        
        public string Nombre;
        
        public System.DateTime Fecha;
        
        public long Numero;
        
        public float Total;
        
        public float Iva;
        
        public float TotalConIva;
        
        public string Destino;
        
        public float Descuento;
        
        public double TipoIva;
        
        public double TipoDescuento;

        public string ConceptoDescuento;
        
        public bool Cobrada;
    }
    
    public struct tFacturaCompras {

        public string Cod_Pro;

        public System.DateTime Fecha;

        public string Numero;

        public float Total;

        public float Iva;

        public float TotalConIva;

        public byte TipoIva;
    }
    
    public struct tAlbaran {
        
        public int Cod_Cli;
        
        public int Cod_Mat;
        
        public System.DateTime Fecha;
        
        public int Numero;
        
        public string Descripcion;
        
        public float Cantidad;
        
        public bool Facturado;
        
        public string Destino;
        
        public string Cliente;
    }
}
