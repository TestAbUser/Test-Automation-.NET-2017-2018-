Feature: CheckTheSameItemCantBeAddedTwice
	Check that if the cart already contains an item
	After clicking "Add to cart" button for the second time for the same item
	It won't be added to the cart again

@mytag
	Scenario: Show if cart contains an item
	Given User is on homepage
	When User clicks on Search field
	And types word brush
	And clicks Find button
	And selects the first item in the list
	And clicks on Add to cart button
	Then the item appears in the cart
	When User goes to the previous page
	And clicks on Add to cart button
	Then the number of items in the cart doesn't change
