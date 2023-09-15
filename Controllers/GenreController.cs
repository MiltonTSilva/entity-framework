using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using entity_framework.ViewModels;

namespace entity_framework.Controllers
{

    /// <summary>
    /// Esse controller é contem os endpoints para cadastrar, atualizar, consultar e deletar genêros
    /// </summary>
    [ApiController]
    [Route("Genre")]
    public class GenreController : ControllerBase
    {
        private readonly ILogger<GenreController> _logger;
        private readonly AppDbContext context;
        private readonly IMapper mapper;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="context"></param>
        /// <param name="mapper"></param>
        public GenreController(ILogger<GenreController> logger,
                               AppDbContext context,
                               IMapper mapper)
        {
             _logger = logger;
            this.context = context;
            this.mapper = mapper;
        }
       
        /// <summary>
        /// Lista todos os gêneros cadastrados
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Genre>>> Get()
        {
            return await context.Genres.ToListAsync();
        }

         /// <summary>
        /// Permite o cadastramento de um gênero
        /// Exemplo:
        /// [
        ///   {
        ///     "name": "Ação"
        ///   },
        /// ]
        /// </summary>
        /// <param name="GenreModel"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> Post(GenreModel GenreModel)
        {

            var yaExisteGenreConEsteNombre = await context.Genres.AnyAsync(g => g.Name == GenreModel.Name);

            if (yaExisteGenreConEsteNombre)
            {
                return BadRequest("Já existe um Genero com esse nome " + GenreModel.Name);
            }

            var Genre = mapper.Map<Genre>(GenreModel);
            context.Add(Genre);
            await context.SaveChangesAsync();
            return Ok();
        }

        /// <summary>
        /// Permite o cadastramento de vários gêneros
        /// Exemplo:
        /// [
        ///   {
        ///     "name": "Ação"
        ///   },
        ///   {
        ///     "name": "Romance"
        ///   },
        /// ]
        /// </summary>
        /// <param name="GenreModel"></param>
        /// <returns></returns>
        [HttpPost("ListGenre")]
        public async Task<ActionResult> Post(GenreModel[] GenreModel)
        {
            var Genres = mapper.Map<Genre[]>(GenreModel);
            context.AddRange(Genres);
            await context.SaveChangesAsync();
            return Ok();
        }


        /// <summary>
        /// Permite alteração de um gênero
        /// </summary>
        /// <param name="id"></param>
        /// <param name="GenreModel"></param>
        /// <returns></returns>
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, GenreModel GenreModel)
        {
            var Genre = mapper.Map<Genre>(GenreModel);
            Genre.Id = id;
            context.Update(Genre);
            await context.SaveChangesAsync();
            return Ok();
        }


        /// <summary>
        /// Permite excluir um gênero
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var Genre = await context.Genres.FirstOrDefaultAsync(g => g.Id == id);

            if (Genre is null)
            {
                return NotFound();
            }

            context.Remove(Genre);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }

/*         [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        } */    
    }