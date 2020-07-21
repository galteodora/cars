using AutoMapper;
using MasiniWebApi.Entities;
using MasiniWebApi.ExternalModels;
using MasiniWebApi.Services.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CarsWebApi.Controllers
{
    [Route("cars")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarsUnitOfWork _carsUnit;
        private readonly IMapper _mapper;

        public CarsController(ICarsUnitOfWork carsUnit,
            IMapper mapper)
        {
            _carsUnit = carsUnit ?? throw new ArgumentNullException(nameof(carsUnit));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        #region Car
        [HttpGet]
        [Route("{id}", Name = "GetCars")]
        public IActionResult GetCars(Guid id)
        {
            var carsEntity = _carsUnit.Car.Get(id);
            if (carsEntity == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<CarsDTO>(carsEntity));
        }

        [HttpGet]
        [Route("details/{id}", Name = "GetCarsDetails")]
        public IActionResult GetCarsDetails(Guid id)
        {
            var carsEntity = _carsUnit.Car.GetCarsDetails(id);
            if (carsEntity == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<CarsDTO>(carsEntity));
        }

        [Route("add", Name = "Add a new car")]
        [HttpPost]
        public IActionResult AddCae([FromBody] CarsDTO cars)
        {
            var carsEntity = _mapper.Map<Cars>(cars);
            _carsUnit.Car.Add(carsEntity);

            _carsUnit.Complete();

            _carsUnit.Car.Get(carsEntity.id);

            return CreatedAtRoute("GetCar",
                new { id = carsEntity.id },
                _mapper.Map<CarsDTO>(carsEntity));
        }
        #endregion Car

        #region Models
        [HttpGet]
        [Route("model/{modelId}", Name = "GetModel")]
        public IActionResult GetModel(Guid modelId)
        {
            var modelEntity = _carsUnit.Models.Get(modelId);
            if (modelEntity == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ModelDTO>(modelEntity));
        }

        [HttpGet]
        [Route("model", Name = "GetAllModels")]
        public IActionResult GetAllModels()
        {
            var modelEntities = _carsUnit.Models.Find(a => a.Deleted == false || a.Deleted == null);
            if (modelEntities == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<List<ModelDTO>>(modelEntities));
        }

        [Route("model/add", Name = "Add a new model")]
        [HttpPost]
        public IActionResult AddModel([FromBody] ModelDTO model)
        {
            if (model is null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            var modelEntity = _mapper.Map<Model>(model);
            _carsUnit.Models.Add(modelEntity);

            _carsUnit.Complete();

            _carsUnit.Models.Get(modelEntity.ID);

            return CreatedAtRoute("GetModel", new { modelId = modelEntity.ID },
                _mapper.Map<ModelDTO>(modelEntity));
        }

        [Route("model/{modelId}", Name = "Audi model as deleted")]
        [HttpPut]
        public IActionResult AudiModelAsDeleted(Guid modelId)
        {
            var model = _carsUnit.Models.FindDefault(a => a.ID.Equals(modelId) && (a.Deleted == false || a.Deleted == null));
            if (model != null)
            {
                model.Deleted = true;
                if (_carsUnit.Complete() > 0)
                {
                    return Ok("Model " + modelId + " was deleted.");
                }
            }
            return NotFound();
        }
        #endregion Models
    }
}