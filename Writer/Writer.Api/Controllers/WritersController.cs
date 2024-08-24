using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Writer.Api.Dtos;
using Writer.Api.Repositories.Interfaces;

namespace Writer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WritersController : ControllerBase
    {
        private IWriterRepository writerRepository;

        public WritersController(IWriterRepository writerRepository)
        {
            this.writerRepository = writerRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllWriters()
        {
            var writers = await writerRepository.GetListAsync();
            return Ok(writers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetWriterDetails(int id)
        {
            var writer = await writerRepository.GetAsync(w => w.Id == id);

            if (writer == null)
            {
                return NotFound();
            }
            return Ok(writer);
        }

        [HttpPost]
        public async Task<IActionResult> CreateWriter([FromBody] WriterCreateDto writerDto)
        {
            // WriterCreateDto'yu Writer modeline dönüştürüyoruz
            var writer = new Models.Writer
            {
                Name = writerDto.Name,

            };

            // Writer nesnesini AddAsync ile veritabanına ekliyoruz
            await writerRepository.AddAsync(writer);

            return Ok(writer);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateWriter(int id, [FromBody] WriterUpdateDto writer)
        {
            var existingWriter = await writerRepository.GetAsync(w => w.Id == id);
            if (existingWriter == null)
            {
                return NotFound();
            }

            existingWriter.Name = writer.Name;

            await writerRepository.UpdateAsync(existingWriter);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWriter(int id)
        {
            var writer = await writerRepository.GetAsync(w => w.Id == id);
            if (writer == null)
            {
                return NotFound();
            }

            await writerRepository.DeleteAsync(writer);
            return Ok();
        }


    }
}
