﻿using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace TareasMVC.Entidades
{
    public class ArchivoAdjunto
    {
        public Guid Id { get; set; }
        public int TareaId { get; set; }
        public Tarea Tarea { get; set; }
        [Unicode]
        public string Url { get; set; }
        public string Titulo { get; set; }
        public int Orden {  get; set; }
        public DateTime FechaCreacion { get; set; }
        public List<Paso> Pasos { get; set; }
        public List<ArchivoAdjunto> ArchivosAdjuntos { get; set; }

    }
}
