Feature: CheckClick
	Checking that after clicking on 
	Cart icon on Home Page the content of the
	Cart is displayed

@mytag
Scenario: Click on the cart icon
	Given User is on homepage
	When User clicks add cart button
	Then The content of the cart is displayed on the screenn

	