Feature: CheckTheCartIsEmpty
	Check that nothing is added to the cart 
	If no item has been selected

@mytag
	Scenario: Show that cart is empty
	Given User is on homepage
	When User clicks on Search field
	And types word brush
	And clicks Find button
	And selects the first item in the list
	And selects 0 items
	And clicks on Add to cart button
	Then the cart stays empty
