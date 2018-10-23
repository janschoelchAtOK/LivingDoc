Feature: GetMoney
		
		In order to do shopping
		As a customer
		I want to get some money from the ATM machine

@inwork
Scenario: Ask for money with valid card
       Given I have inserted my card into the ATM machine
       And my card is valid
	   When I ask for 1000 bucks
	   Then the machine should give me 1000 bucks
	   And it should give me my card back