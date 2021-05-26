﻿
using Philcosa.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Philcosa.Domain.Entities
{
    public class Cover : AuditableEntity
    {
        public DateTime CoverDate { get; set; }

        public string IdOnDate { get; set; }

        public int? IssuedById { get; set; }

        public IssuedByEntity IssuedBy { get; set; }

        [MaxLength(10)]
        public string Number { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }

        [MaxLength(7)]
        public string AmountIssued { get; set; }

        [MaxLength(5)]
        public string Atlas { get; set; }

        [MaxLength(5)]
        public string Alberta { get; set; }

        public CoverType CoverType { get; set; }

        public CoverValue Value { get; set; }

        public Country Country { get; set; }

        public string Path { get; set; }

        public IList<CoverTheme> CoverThemes { get; set; }
    }
}