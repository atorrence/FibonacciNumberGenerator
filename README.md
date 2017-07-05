# FibonacciNumberGenerator
<h2> ReadMe</h2>


<p>This is a new project that I completed using the ASP.NET MVC pattern. I incorportated stlying with CSS and Bootstrap. I also included
a Data Access Layer to store information in and retrieve information from a database.</p>

<p>These are the paramaters: </p>
<ul>
	<li>Create a web page that calculates the nth Fibonacci number. For example, entering 14 will yield 377 and 78 yields 8944394323791464. </li>
	<li>Style -- simply but nicely – use of CSS / CSS frameworks encouraged. </li>
	<li>The page should remember the previous 10 queries from all users, and show their result and the originating IP address somewhere on the page.</li>
	<li>Include URL of a live version of this site and show the source code on GitHub. </li>
</ul>

<p>Here is the <a href="http://fibonaccinumbergenerator.apphb.com/"> link </a> to the site.<p>

<p>Design decisions/Problems encountered</p>
	<ul>
		<li>Decided to use MVC to be able to display different views</li>
		<li>Added bootstrap to allow for a nav bar and the ability to toggle between the input view and the display view</li>
		<li>Opted for one controller - I originally had twocontroller, but the information is all realted, so there was not a need to break it apart</li>
		<li>Through unit testing, I determined that setting the values as integers did not allow for enough memory for the larger numbers.  I changed data type to long. </li>
		<li>Even with the data type as long, any Fibonacci Sequence number greater than the 92nd number was too large.  I added instructions to select an input number less than 93.</li>
	</ul>
	
<p>Improvements planned for further iterations:</p>
	<ul>
		<li>Set up client side validation for the input number (limit the user from entering a number greater than 92)</li>
	</ul>
