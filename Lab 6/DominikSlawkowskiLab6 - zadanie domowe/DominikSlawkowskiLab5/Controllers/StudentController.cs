using DominikSlawkowskiLab5.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace DominikSlawkowskiLab5.Controllers
{
    [RoutePrefix("api/students")] //adres uzywany w lokalhoscie do uzywania metod
    public class StudentController : ApiController
    {
        private static readonly List<StudentDto> _students; //static jest po to zeby nie tworzyc listy za kazdym razem przy wysylaniu zapytan
        
        /// <summary>
        /// Konstruktor statyczny
        /// </summary>
        static StudentController()
        {
            _students = new List<StudentDto>
            {
                new StudentDto {
                    Id =1,
                    FirstName ="New Len Faki's Album is awesome",
                    LastName ="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed vestibulum ex sed elementum pretium. Suspendisse pellentesque eget libero non bibendum. Phasellus nec porta libero. Vivamus pellentesque feugiat ultricies. Donec pharetra lacus laoreet ante pulvinar viverra. Nullam eu mollis turpis. Nam eu nulla vel odio vulputate euismod id ullamcorper lectus. Aliquam mollis nulla tortor, at bibendum nunc elementum id. Pellentesque id porttitor massa. Sed sit amet varius lectus, sed gravida nisi. Mauris purus purus, sodales id nisi vitae, placerat pretium est. Duis blandit sodales arcu, vel accumsan dui rutrum eu. Ut suscipit nisl id lorem cursus sollicitudin fringilla ut lectus. Praesent eget dictum dui.",
                    City ="Zielona Góra"},

                new StudentDto {
                    Id =2,
                    FirstName ="Chris Liebing plays live in Berghain!",
                    LastName ="Vestibulum blandit molestie enim ut vestibulum. Ut quis consequat diam. Nam sollicitudin placerat pharetra. Curabitur varius venenatis porta. In hac habitasse platea dictumst. Pellentesque dignissim vulputate erat in posuere. Curabitur id iaculis ligula, vitae interdum tortor. Praesent vel erat ut tortor egestas venenatis. Aenean vitae metus porta, sollicitudin massa porttitor, malesuada turpis. Nam sollicitudin dui elit, ac tempus ante blandit sollicitudin. Integer tristique risus eget lobortis consequat. Pellentesque nulla dolor, viverra quis tortor eget, mattis commodo tortor. In hac habitasse platea dictumst. Phasellus mollis eget augue quis tristique. Nulla quis tincidunt eros, tempor lacinia nisl.",
                    City ="Zielona Góra"},

                new StudentDto {
                    Id =3,
                    FirstName ="My best trance Djs",
                    LastName ="Nulla sit amet sapien id est semper fermentum. Maecenas accumsan odio eu eros sollicitudin congue. Phasellus in semper ex, in consequat dolor. Ut vel cursus sem, ac commodo nunc. Duis et enim pretium, cursus tellus ut, ornare tellus. Fusce gravida nisi lacus, at semper lectus euismod ut. Aliquam tempus ultricies mauris eu tincidunt. Suspendisse finibus erat ut gravida consectetur. Nulla massa nisi, gravida vitae lorem sed, faucibus fermentum tellus. Praesent tempor vulputate elementum. Nam in eleifend sem. Sed ac rutrum mi, vel convallis massa. Proin et euismod nunc. Cras convallis in elit sed eleifend. Fusce sollicitudin tellus eu nisi vestibulum mattis.",
                    City ="Zielona Góra"}
            };
        }
     
        /// <summary>
        /// Metoda Get pobierajaca wszystkie informacje o obiektach z listy
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("")] // wykonywana akcja + po jakim hoscie ma byc przekierowanie do metody
        [ResponseType(typeof(List<StudentDto>))] //Typ  zwracanych danych
        public IHttpActionResult Get() //interfejs do zwracania statsu codow
        {
            return Ok(_students);
        }
        
        /// <summary>
        /// Metoda Get z parametrem pobierajaca informacje o obiekcie o zadanym id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet, Route("{id:int}", Name = "GetStudent")] //taka sama nazwa jak w argumencie!! + dodajemy nazwe dla metody Get(int id) zeby mozna bylo ja wyszukac w metodzie Post
        [ResponseType(typeof(StudentDto))]
        public IHttpActionResult Get(int id)
        {
            var student = _students.SingleOrDefault(x => x.Id == id); // x symbolizuje studenta (wyrazenie lambda)

            if(student == null)
            {
                return NotFound(); //blad 404
            }
            return Ok(student); //200 OK
        }

        /// <summary>
        /// Metoda dodajaca do listy
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        [HttpPost, Route("")]
        public IHttpActionResult Post([FromBody] StudentDto student)
        {
            if(!ModelState.IsValid) //sprawdzamy czy obiekt jest poprawnie wprowadzony
            {
                return BadRequest(ModelState);//lista bledow
            }

            var maxId = _students.Max(x => x.Id); // metoda zwracajaca maksymalne id wystepujace w naszej liscie
            student.Id = ++maxId;

            _students.Add(student);

            return CreatedAtRoute("GetStudent", new {id = student.Id}, student); // obiekt anonimowy

        }

        /// <summary>
        /// Metoda edytujaca obiekt o zadanym id z listy
        /// </summary>
        /// <param name="student"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut, Route("{id:int}")]
        public IHttpActionResult Put([FromBody] StudentDto student, int id)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var studentToEdit = _students.SingleOrDefault(x => x.Id == id);

            if (studentToEdit == null)
            {
                return NotFound();
            }

            studentToEdit.FirstName = student.FirstName;
            studentToEdit.LastName = student.LastName;
            studentToEdit.City = student.City;

            return StatusCode(HttpStatusCode.NoContent);

        }

        /// <summary>
        /// Metoda usuwajaca obiekt z listy
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete, Route("{id:int}")]
        public IHttpActionResult Delete(int id)
        {
            var student = _students.SingleOrDefault(x => x.Id == id);
            if(student == null)
            {
                return NotFound();
            }

            _students.Remove(student);
            return StatusCode(HttpStatusCode.NoContent);
        }

       }
}
