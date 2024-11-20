Feature: CheckThatCartHasItem
Checking that after selecting an item and
Clicking 'Add to Cart' button
The item appears in the cart

@mytag
	Scenario: Show if cart contains an item
	Given User is on homepage
	When User clicks on Search field
	And types word brush
	And clicks Find button
	And selects the first item in the list
	And clicks on Add to cart button
	Then the item appears in the cart
