using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NPF_MultiplesOfEleven.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NPF_MultiplesOfEleven.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MultiplesOfElevenController : ControllerBase
    {

        private readonly ILogger<MultiplesOfElevenController> _logger;

        public MultiplesOfElevenController(ILogger<MultiplesOfElevenController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public MultipleOfElevenOutputData Get(MultipleOfElevenInputData input)
        {
            try
            {
                var results = new List<Result>();
                //Varreno a lista
                foreach (var item in input.Numbers)
                {
                    //O resto da divisão de um número´pelo seu múltiplo é zero. 
                    results.Add(new Result { IsMultiple = (int.Parse(item) % 11 == 0), Number = item });
                }

                var output = new MultipleOfElevenOutputData
                {
                    Result = results
                };

                return output;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
            
           
        }
    }
}
