Feature: CheckSearchResultAgainstTable
Check that the added item has the
Necessary properties, defined within the feature

@mytag
Scenario: Checks that the added item matches certain parameters
	Given User has to acquire a certain item:
	| Name       | Value                                                                          |
	| SellerName | fufulliuliu                                                                    |
	| ProductName| 4pcs Eyeshadow Eye Shadow Foundation Blending Brush Set Makeup Cosmetic Tool   |
	| Price      | US $1,89                                                                       |
	Given User is on homepage
	When User clicks on Search field
	And types word brush
	And clicks Find button
	And selects the first item in the list
	And clicks on Add to cart button
	Then User can assert that the required item is present
