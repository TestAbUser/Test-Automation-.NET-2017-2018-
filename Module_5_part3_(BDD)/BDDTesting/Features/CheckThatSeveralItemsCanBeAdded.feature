Feature: CheckThatSeveralItemsCanBeAdded
Check that if more than one item of the same kind are selected
Then all of them can be added to the cart

@mytag
Scenario Outline: Check That Several Items Can Be Added
	Given User is on homepage
	When User clicks on Search field
	And types word brush
	And clicks Find button
	And selects the first item in the list
	And puts number of the items as <inputNumber>
	And clicks on Add to cart button
    Then the number of items in the cart changes to <expectedNumber>
	
	Examples:
	| inputNumber | expectedNumber  |
	| 3           |  3              |
	| 2           |  2              |
