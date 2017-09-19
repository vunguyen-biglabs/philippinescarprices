# philippinescarprices

If you want to buy a car in Philippines, you’ll notice the difference of price as below
<ol>
	<li>Two cars, for example Jeep Grand Cherokee 6.4L and BMW M2 3.0L, the tax is
different, 6.4L car will have higher tax rate</li>
	<li>Two cars, same capacity in ccm like 3.0L, the cars imported from USA and Japan
is comparatively cheaper than the car from Europe</li>
</ol>
If we have a table about import tax rate of as below:

 
<table>
<tbody>
<tr>
<td width="153"><strong> </strong></td>
<td width="165"><=2.0L</td>
<td width="153">>2.0L & <= 5.0L</td>
<td width="153">>5.0L</td>
</tr>
<tr>
<td width="153">Europe</td>
<td width="165">100%</td>
<td width="153">120%</td>
<td width="153">200%</td>
</tr>
<tr>
<td width="153">USA</td>
<td width="165">75%</td>
<td width="153">90%</td>
<td width="153">150%</td>
</tr>
<tr>
<td width="153">Japan</td>
<td width="165">70%</td>
<td width="153">80%</td>
<td width="153">135%</td>
</tr>
</tbody>
</table>
Also if you want to buy anything in philippines, you need to pay VAT 12%
Now please write an program to calculate the price end user should pay, we assume the
formula is
<table>
<tbody>
<tr>
<td width="623">(end-user price) = (original price) + (import tax) + VAT
(import tax) = (original price ) * (import tax rate)
VAT = ((original price) + (import tax)) * 12%</td>
</tr>
</tbody>
</table>
Now we have 4 cars:
<ol>
	<li>Benz G65 from Germany (Europe county), 6.0L, original price $217,900USD</li>
	<li>Honda Jazz 1.5L (Japan) original price $19,490 USD</li>
	<li>Jeep wrangler 3.6L (USA) original price, $36,995USD</li>
	<li>Chery QQ 1.0L (China) original price, $6,000USD</li>
</ol>
If we use the exchange rate 1 USD =47 Pesos.

Please write down your program to calculate the car end-user price in Philippine Pesos, and write down your unit test.

Requirement:
<ol>
	<li>With unit tests</li>
	<li>No duplication</li>
	<li>No if-else, switch</li>
</ol>
