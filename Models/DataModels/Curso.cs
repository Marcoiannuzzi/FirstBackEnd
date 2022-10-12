﻿using System.ComponentModel.DataAnnotations;

namespace FirstBackEnd.Models.DataModels
{
    public class Curso
    {
        [Required, MaxLength(50)]
        public string Nombre { get; set; } = string.Empty;

        [Required, MaxLength(280)]
        public string Descripcion { get; set; } = string.Empty;
        public string DescripcionLarga { get; set; } = string.Empty;
        public string PublicoObjetivo { get; set; } = string.Empty;
        public string Objetivos { get; set; } = string.Empty;
        public string Requisitos { get; set; } = string.Empty;
        
    }
}
