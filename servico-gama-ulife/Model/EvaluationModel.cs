﻿using System;

namespace servico_gama_ulife.Model
{
    public class EvaluationModel
    {
        public int Nr_evaluationid { get; set; }
        public string Nm_evaluation { get; set; }
        public int Nr_userid { get; set; }
        public double Nr_questionnaireid { get; set; }
        public DateTime Dt_creationdate { get; set; }
        public DateTime Dt_modifieddate { get; set; }

    }
}
