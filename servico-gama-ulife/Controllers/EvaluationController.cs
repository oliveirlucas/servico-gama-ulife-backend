﻿using Microsoft.AspNetCore.Mvc;
using servico_gama_ulife.Mapper;
using servico_gama_ulife.Model;
using servico_gama_ulife.Response;
using servico_gama_ulife.Service.Interface;
using System.Collections.Generic;

namespace servico_gama_ulife.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EvaluationController : ControllerBase
    {
        private readonly IEvaluationService _evaluationService;
        private readonly IObjectConverter _objectConverter;

        public EvaluationController(IEvaluationService evaluationService, IObjectConverter objectConverter)
        {
            _evaluationService = evaluationService;
            _objectConverter = objectConverter;
        }

        /// <summary>
        /// Retorna todos as avaliações
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetEvaluation()
        {
            IList<EvaluationModel> evaluation = _evaluationService.GetEvaluation();
            return Ok(_objectConverter.Map<IList<EvaluationModel>>(evaluation));
        }

        /// <summary>
        /// Buscar avaliação por id
        /// </summary>
        /// <param name="nr_evaluationid"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetEvaluationById/{nr_evaluationid}")]
        public IActionResult GetEvaluationById([FromRoute] int nr_evaluationid)
        {
            var evaluation = _evaluationService.GetEvaluationById(nr_evaluationid);
            return Ok(_objectConverter.Map<EvaluationResponse>(evaluation));
        }

        /// <summary>
        /// Atualizar nota e status
        /// </summary>
        /// <param name="updateUserEvaluation"></param>
        /// <returns></returns>

    }
}