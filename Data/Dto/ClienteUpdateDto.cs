﻿namespace PRIMERA_API.Data.Dto
{
    public class ClienteUpdateDto
    {
        public int ClienteID { get; set; }
        public string Nombre { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Telefono { get; set; } = null!;
    }
}
