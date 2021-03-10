/*
    1. Query all of the entries in the Genre table

    2. Query all the entries in the Artist table and order by the artist's name. HINT: use the ORDER BY keywords

    3. Write a SELECT query that lists all the songs in the Song table and include the Artist name

    4. Write a SELECT query that lists all the Artists that have a Pop Album

    5. Write a SELECT query that lists all the Artists that have a Jazz or Rock Album

    6. Write a SELECT statement that lists the Albums with no songs

    7. Using the INSERT statement, add one of your favorite artists to the Artist table.

    8. Using the INSERT statement, add one, or more, albums by your artist to the Album table.

    9. Using the INSERT statement, add some songs that are on that album to the Song table.

    10. Write a SELECT query that provides the song titles, album title, and artist name 
        for all of the data you just entered in. Use the LEFT JOIN keyword sequence to connect the tables, 
        and the WHERE keyword to filter the results to the album and artist you added.

        Reminder: Direction of join matters. Try the following statements and see the difference in results.

        SELECT a.Title, s.Title FROM Album a LEFT JOIN Song s ON s.AlbumId = a.Id;
        SELECT a.Title, s.Title FROM Song s LEFT JOIN Album a ON s.AlbumId = a.Id;
*/

/* NOTE: Since this script doesn't do any of the INSERTS, this query just picks some existing values...*/

select s.Title as SongTitle, al.Title as AlbumTitle, ar.ArtistName
  from song s
       join Album al on s.AlbumId = al.id
       join artist ar on s.ArtistId = ar.id
 where s.Title = 'TV Party' 
       or s.Title = 'Thug'
       or ar.ArtistName = 'Beatles'

/*
    11. Write a SELECT statement to display how many songs exist for each album. 
        You'll need to use the COUNT() function and the GROUP BY keyword sequence.
*/


SELECT count(s.id), al.Title
  FROM  song s LEFT JOIN album al on s.AlbumId = al.id
GROUP BY al.Title

UNION

SELECT 0, al.Title
  FROM Album al LEFT JOIN Song s on al.Id = s.AlbumId
WHERE s.id is null

/*
You might be wondering about the "UNION" and second query.

"UNION" is a way to combine the results of two queries into one result set.
And the second query returns all the albums that do not have songs.

So, the full query above will return the count of songs in each album 
INCLUDING returning 0 for albums that have no songs.
*/



/*

    12. Write a SELECT statement to display how many songs exist for each artist. 
        You'll need to use the COUNT() function and the GROUP BY keyword sequence.
*/

SELECT count(s.id), ar.ArtistName
  FROM  song s LEFT JOIN Artist ar on s.ArtistId = ar.id
GROUP BY ar.ArtistName

UNION

SELECT 0, ar.ArtistName
  FROM Artist ar LEFT JOIN Song s on ar.Id = s.ArtistId
WHERE s.id is null


/*
    13. Write a SELECT statement to display how many songs exist for each genre. 
        You'll need to use the COUNT() function and the GROUP BY keyword sequence.
*/

SELECT count(s.id), g.Label
  FROM  song s LEFT JOIN Genre g on s.GenreId = g.id
GROUP BY g.Label

UNION

SELECT 0, g.label
  FROM genre g LEFT JOIN Song s on g.Id = s.GenreId
WHERE s.id is null


/*

    14. Write a SELECT query that lists the Artists that have put out records on more than one record label. 
        Hint: When using GROUP BY instead of using a WHERE clause, use the HAVING keyword
*/

select count(distinct al.label), ar.ArtistName
from Artist ar JOIN Album al on ar.id = al.ArtistId
group by ar.ArtistName
having count(distinct al.label) > 1

/*
    15. Using MAX() function, write a select statement to find the album with the longest duration. 
        The result should display the album title and the duration.
*/

select al.Title, al.AlbumLength
  from Album al
 where al.AlbumLength = (
    select max(al.albumlength) 
      from album al
);

select top 1 al.Title, al.albumlength
from Album al
order by al.AlbumLength desc;


/*
    16. Using MAX() function, write a select statement to find the song with the longest duration. 
        The result should display the song title and the duration.
*/

select s.Title, s.SongLength
  from song s
 where s.SongLength = (
    select max(s.SongLength) 
      from song s
);

  select top 1 s.Title, s.SongLength
    from song s 
order by s.SongLength desc;


/*
    17. Modify the previous query to also display the title of the album.
*/

  select top 1 s.Title, s.SongLength, al.Title
    from song s join Album al on s.AlbumId = al.id
order by s.SongLength desc;

