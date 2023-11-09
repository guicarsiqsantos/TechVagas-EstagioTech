﻿using System.ComponentModel.DataAnnotations.Schema;
using TechVagas_EstagioTech.Dtos.Entities;

namespace TechVagas_EstagioTech.Model.Entities
{
    [Table("vagas")]
    public class VagasModel
	{
        [Column("vagasid")]
        public int VagasId { get; set; }

        [Column("quantidade")]
        public int Quantidade { get; set; }

        [Column("datapublicacao")]
        public DateTime DataPublicacao { get; set; }

        [Column("datalimite")]
        public DateTime DataLimite { get; set; }

        [Column("localidade")]
        public string? Localidade { get; set; }

        [Column("descricao")]
        public string? Descricao { get; set; }

        [Column("titulo")]
        public string? Titulo { get; set; }

        [Column("localidadetrabalho")]
        public string? LocalidadeTrabalho { get; set; }

        [Column("horarioentrada")]
        public string? HorarioEntrada { get; set; }

        [Column("horariosaida")]
        public string? HorarioSaida { get; set; }

        [Column("totalhorassemanais")]
        public string? TotalHorasSemanis { get; set; }

        public ConcedenteModel? Concedente { get; set; }
		public int concedenteId { get; set; }

		public ICollection<CargoModel>? Cargos { get; set; }

		
	}
}
