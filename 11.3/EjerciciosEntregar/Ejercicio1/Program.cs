internal class Program
{
    private static void Main(string[] args)
    {

        // Las Listas nos exigen que definamos el tipo de los elementos de la lista, en cambio, la lista de anónimos
        // inmutable crea un array de anónimos en los que no necesitamos definir ningún tipo

        List<Libro> libros = new List<Libro>
        {
            new Libro
            {
                Titulo = "Don Quijote de la Mancha",
                Autor = "Miguel de Cervantes",
                Editorial = "Editorial EDAF, S.A",
                NumPaginas = 765,
                ISBN = "9788441405298",
                Reseña = @"El libro, sinopsis… Nos presentan a este personaje como un loco 
                   trastornado a causa de las novelas de caballerías, pero, 
                   ¿Quién dice que el señor Quijana era sólo eso? 
                   ¿Por algún motivo será la cumbre de la literatura española verdad? 
                   Y aquí se plantea la duda héroe o simplemente viejo loco."

    },

            new Libro
            {

                Titulo = "El camino",
                Autor = "Miguel Delibes",
                Editorial = "Espasa",
                NumPaginas = 187,
                ISBN = "9788467023664",
                Reseña = "Una de las más importantes obras de Miguel Delibes cuenta la historia de un niño , Daniel el Mochuelo, que tiene que trasladarse a la ciudad para cursar bachillerato. Una noche antes de partir Daniel recordará todo lo que le ha ocurrido en este lugar, sus amigos, sus peripecias, y descubrirá que su camino está en esa aldea, unido a lo que ha sido hasta ese momento su vida. Nostálgica novela realista a través de la cual podemos aprender que nunca sabemos lo que tenemos hasta que se nos ha escapado."

            },

            new Libro
            {
                Titulo = "Cien años de soledad",
                Autor = "Gabriel García Márquez",
                Editorial = "Alfaguara",
                NumPaginas = 562,
                ISBN = "9788420471839",
                Reseña = "Muchos años después, frente al pelotón de fusilamiento, el coronel Aureliano Buendía había de recordar aquella tarde remota en que su padre lo llevó a conocer el hielo.» Con estas palabras empieza una novela ya legendaria en los anales de la literatura universal, una de las aventuras literarias más fascinantes de nuestro s iglo.Millones de ejemplares de Cien años de soledad leídos en todas las lenguas y el premio Nobel de Literatura coronando una obra que se había abierto paso «boca a boca» -como gusta decir el escritor-son la más palpable demostración de que la aventura fabulosa de la familia Buendía - Iguarán, con sus milagros, fantasías, obsesiones, tragedias, incestos, adulterios, rebeldías, descubrimientos y condenas, representaba al mismo tiempo el mito y la historia, la tragedia y el amor del mundo entero."
            },
        };


        var listaInmutable = new[]
        {
            new 
            {
                Titulo = "Cien años de soledad",
                Autor = "Gabriel García Márquez",
                Editorial = "Alfaguara",
                NumPaginas = 562,
                ISBN = "9788420471839",
                Reseña = "Muchos años después, frente al pelotón de fusilamiento, el coronel Aureliano Buendía había de recordar aquella tarde remota en que su padre lo llevó a conocer el hielo.» Con estas palabras empieza una novela ya legendaria en los anales de la literatura universal, una de las aventuras literarias más fascinantes de nuestro s iglo.Millones de ejemplares de Cien años de soledad leídos en todas las lenguas y el premio Nobel de Literatura coronando una obra que se había abierto paso «boca a boca» -como gusta decir el escritor-son la más palpable demostración de que la aventura fabulosa de la familia Buendía - Iguarán, con sus milagros, fantasías, obsesiones, tragedias, incestos, adulterios, rebeldías, descubrimientos y condenas, representaba al mismo tiempo el mito y la historia, la tragedia y el amor del mundo entero."            
            },

             new 
            {

                Titulo = "El camino",
                Autor = "Miguel Delibes",
                Editorial = "Espasa",
                NumPaginas = 187,
                ISBN = "9788467023664",
                Reseña = "Una de las más importantes obras de Miguel Delibes cuenta la historia de un niño , Daniel el Mochuelo, que tiene que trasladarse a la ciudad para cursar bachillerato. Una noche antes de partir Daniel recordará todo lo que le ha ocurrido en este lugar, sus amigos, sus peripecias, y descubrirá que su camino está en esa aldea, unido a lo que ha sido hasta ese momento su vida. Nostálgica novela realista a través de la cual podemos aprender que nunca sabemos lo que tenemos hasta que se nos ha escapado."

            },
        };
    }
}