# UnitTesting

## OddEven Kata

#### Goal

Write a program that prints numbers within specified range lets say 1 to 100.
If number is odd print 'Odd' instead of the number.
If number is even print 'Even' instead of number.
Else print number [hint - if number is Prime].

#### Steps

Lets divide into following steps:
* Prints numbers from 1 to 100
* Print "Even" instead of number, if the number is even, means divisible by 2
* Print "Odd" instead of number, if the number is odd, means not divisible by 2 but not divisible by itself too [hint - it should not be Prime]
* Print number, if it does not meet above two conditions, means if number is Prime
* Make method to accept any number of range [currently  we have 1 to 100]
* Create a new method to check Odd/Even/Prime of a single supplied method


## Harry Potter Kata

To try and encourage more sales of the 5 different Harry
Potter books they sell, a bookshop has decided to offer
discounts of multiple-book purchases.

One copy of any of the five books costs 8 EUR.

If, however, you buy two different books, you get a 5%
discount on those two books.

If you buy 3 different books, you get a 10% discount.

If you buy 4 different books, you get a 20% discount.

If you go the whole hog, and buy all 5, you get a huge 25%
	discount.

Note that if you buy, say, four books, of which 3 are
	different titles, you get a 10% discount on the 3 that
	form part of a set, but the fourth book still costs 8 EUR.

Your mission is to write a piece of code to calculate the
	price of any conceivable shopping basket (containing only
	Harry Potter books), giving as big a discount as possible.

For example, how much does this basket of books cost?

	2 copies of the first book
	2 copies of the second book
	2 copies of the third book
	1 copy of the fourth book
	1 copy of the fifth book

	Answer: 51.60 EUR
  
## Word Wrap Kata

Create a function which breaks words on specified space with new line. Its nothing but merely similar to word-processor.

#### Steps

* Create a public class named WordWrap
* Create a method 'wrap' it can be a static method
* Create a function which count the number of splitter words of non-space
* check for if words already having newline ['\n'] characters - ignore in counts
* Check for multiple lines
* Remove blank spaces if any in new line eg. Actual - "this is a test" WrappedText = "this\n is a t\nest"

#### References
