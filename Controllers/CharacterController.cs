using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using PoESnap.Controllers.ApiModels;
using PoESnap.Services.CharacterService;

namespace PoESnap.Controllers
{
    [ApiController]
    [EnableCors]
    [Route("api/[controller]")]
    public class CharacterController : Controller
    {
        private readonly ILogger<CharacterController> _logger;
        private readonly ICharacterService _characterService;

        public CharacterController(ILogger<CharacterController> logger, ICharacterService characterService) 
        {
            _logger = logger;
            _characterService = characterService;
        }

        [HttpGet("{characterName}")]
        public IActionResult GetCharacterByName(string characterName)
        {
            Models.Character character;

            if (string.IsNullOrWhiteSpace(characterName))
            {
                return BadRequest("Character name must be provided.");
            }

            try
            {
                character = _characterService.GetCharacterAsync(characterName).Result;
            }
            catch (BadHttpRequestException ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return NotFound(ex.Message);
            }

            if (character == null)
            {
                return NotFound();
            }

            return Ok(character);
        }

        [HttpPost]
        public IActionResult AddCharacter(AddCharacterModel addCharacterModel)
        {
            if (addCharacterModel == null || addCharacterModel.AccountName == null || addCharacterModel.CharacterName == null)
            {
                return BadRequest(ModelState);
            }
            _characterService.AddCharacter(addCharacterModel.AccountName, addCharacterModel.CharacterName);
            
            return Ok(addCharacterModel);
        }
    }
}
