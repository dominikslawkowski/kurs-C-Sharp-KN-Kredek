﻿using DominikSlawkowskiLab5.Dtos;
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
    public class PostController : ApiController
    {
        private static readonly List<PostDto> _students; //static jest po to zeby nie tworzyc listy za kazdym razem przy wysylaniu zapytan
        
        /// <summary>
        /// Konstruktor statyczny
        /// </summary>
        static PostController()
        {
            _students = new List<PostDto>
            {
                new PostDto { Id=1, Title="Dominik",     Body="Sławkowski",  Author="Zielona Góra"},
                new PostDto { Id=2, Title="Wojtek",      Body="Dunaj",       Author="Zielona Góra"},
                new PostDto { Id=3, Title="Mateusz",     Body="Witkowski",   Author="Zielona Góra"}
            };
        }
     
        /// <summary>
        /// Metoda Get pobierajaca wszystkie informacje o obiektach z listy
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("")] // wykonywana akcja + po jakim hoscie ma byc przekierowanie do metody
        [ResponseType(typeof(List<PostDto>))] //Typ  zwracanych danych
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
        [ResponseType(typeof(PostDto))]
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
        public IHttpActionResult Post([FromBody] PostDto student)
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
        public IHttpActionResult Put([FromBody] PostDto student, int id)
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

            studentToEdit.Title = student.Title;
            studentToEdit.Body = student.Body;
            studentToEdit.Author = student.Author;

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