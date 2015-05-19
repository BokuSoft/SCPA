--region Drop Existing Procedures

	DROP PROCEDURE IF EXISTS `usp_InsertAccount`;

	DROP PROCEDURE IF EXISTS `usp_UpdateAccount`;

	DROP PROCEDURE IF EXISTS `usp_InsertUpdateAccount`;

	DROP PROCEDURE IF EXISTS `usp_DeleteAccount`;

	DROP PROCEDURE IF EXISTS `usp_SelectAccount`;

	DROP PROCEDURE IF EXISTS `usp_SelectAccountsAll`;

	DROP PROCEDURE IF EXISTS `usp_SelectAccountsByUniqueID`;

--region `usp_InsertAccount`

------------------------------------------------------------------------------------------------------------------------
-- Author:           Phosphor
-- Procedure Name: `usp_InsertAccount`
-- Date: domingo, 17 de mayo de 2015
------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE `usp_InsertAccount`
	(IN pUniqueID Int,
	IN pEmail VarChar(80),
	IN pFirstName VarChar(80),
	IN pLastName VarChar(80),
	IN pAddress1 VarChar(80),
	IN pAddress2 VarChar(80),
	IN pCity VarChar(80),
	IN pState VarChar(80),
	IN pZip VarChar(20),
	IN pCountry VarChar(20),
	IN pPhone VarChar(20),
	OUT pAccountID Int)


BEGIN
INSERT INTO Account (
	`UniqueID`,
	`Email`,
	`FirstName`,
	`LastName`,
	`Address1`,
	`Address2`,
	`City`,
	`State`,
	`Zip`,
	`Country`,
	`Phone`
) VALUES (
	pUniqueID,
	pEmail,
	pFirstName,
	pLastName,
	pAddress1,
	pAddress2,
	pCity,
	pState,
	pZip,
	pCountry,
	pPhone
);

SET pAccountID = (SELECT MAX(AccountID) FROM `Account` ); 
END;

--endregion


--region `usp_UpdateAccount`

------------------------------------------------------------------------------------------------------------------------
-- Author:           Phosphor
-- Procedure Name: `usp_UpdateAccount`
-- Date: domingo, 17 de mayo de 2015
------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE `usp_UpdateAccount`
	(IN pAccountID Int,
	IN pUniqueID Int,
	IN pEmail VarChar(80),
	IN pFirstName VarChar(80),
	IN pLastName VarChar(80),
	IN pAddress1 VarChar(80),
	IN pAddress2 VarChar(80),
	IN pCity VarChar(80),
	IN pState VarChar(80),
	IN pZip VarChar(20),
	IN pCountry VarChar(20),
	IN pPhone VarChar(20))


UPDATE `Account` SET
	`UniqueID` = pUniqueID,
	`Email` = pEmail,
	`FirstName` = pFirstName,
	`LastName` = pLastName,
	`Address1` = pAddress1,
	`Address2` = pAddress2,
	`City` = pCity,
	`State` = pState,
	`Zip` = pZip,
	`Country` = pCountry,
	`Phone` = pPhone
WHERE
	`AccountID` =  pAccountID;
--endregion


--region `usp_InsertUpdateAccount`

------------------------------------------------------------------------------------------------------------------------
-- Author:           Phosphor
-- Procedure Name: `usp_InsertUpdateAccount`
-- Date: domingo, 17 de mayo de 2015
------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE `usp_InsertUpdateAccount`
	(IN pAccountID Int,
	IN pUniqueID Int,
	IN pEmail VarChar(80),
	IN pFirstName VarChar(80),
	IN pLastName VarChar(80),
	IN pAddress1 VarChar(80),
	IN pAddress2 VarChar(80),
	IN pCity VarChar(80),
	IN pState VarChar(80),
	IN pZip VarChar(20),
	IN pCountry VarChar(20),
	IN pPhone VarChar(20))

BEGIN
IF EXISTS(SELECT `AccountID` FROM `Account` WHERE `AccountID` =  pAccountID)THEN
	UPDATE `Account` SET
		`UniqueID` = pUniqueID,
		`Email` = pEmail,
		`FirstName` = pFirstName,
		`LastName` = pLastName,
		`Address1` = pAddress1,
		`Address2` = pAddress2,
		`City` = pCity,
		`State` = pState,
		`Zip` = pZip,
		`Country` = pCountry,
		`Phone` = pPhone
	WHERE
		`AccountID` =  pAccountID;ELSE
	INSERT INTO `Account` (
		`AccountID`,
		`UniqueID`,
		`Email`,
		`FirstName`,
		`LastName`,
		`Address1`,
		`Address2`,
		`City`,
		`State`,
		`Zip`,
		`Country`,
		`Phone`
	) VALUES (
		pAccountID,
		pUniqueID,
		pEmail,
		pFirstName,
		pLastName,
		pAddress1,
		pAddress2,
		pCity,
		pState,
		pZip,
		pCountry,
		pPhone
	);
END IF;

END;

--endregion


--region `usp_DeleteAccount`

------------------------------------------------------------------------------------------------------------------------
-- Author:           Phosphor
-- Procedure Name: `usp_DeleteAccount`
-- Date: domingo, 17 de mayo de 2015
------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE `usp_DeleteAccount`
	(IN pAccountID Int)


DELETE FROM `Account`
WHERE
	`AccountID` =  pAccountID;
--endregion


--region `usp_DeleteAccountsByUniqueID`

------------------------------------------------------------------------------------------------------------------------
-- Author:           Phosphor
-- Procedure Name: `usp_DeleteAccountsByUniqueID`
-- Date: domingo, 17 de mayo de 2015
------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE `usp_DeleteAccountsByUniqueID`
	(IN pUniqueID Int)


DELETE FROM `Account`
WHERE
	`UniqueID` =  pUniqueID;

--endregion



--region `usp_SelectAccount`

------------------------------------------------------------------------------------------------------------------------
-- Author:           Phosphor
-- Procedure Name: `usp_SelectAccount`
-- Date: domingo, 17 de mayo de 2015
------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE `usp_SelectAccount`
	(IN pAccountID Int)

SELECT
	`AccountID`,
	`UniqueID`,
	`Email`,
	`FirstName`,
	`LastName`,
	`Address1`,
	`Address2`,
	`City`,
	`State`,
	`Zip`,
	`Country`,
	`Phone`
FROM
	`Account`
WHERE
	`AccountID` =  pAccountID;
--endregion


--region `usp_SelectAccountsByUniqueID`

------------------------------------------------------------------------------------------------------------------------
-- Author:           Phosphor
-- Procedure Name: `usp_SelectAccountsByUniqueID`
-- Date: domingo, 17 de mayo de 2015
------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE `usp_SelectAccountsByUniqueID`
	(IN pUniqueID Int)

SELECT
	`AccountID`,
	`UniqueID`,
	`Email`,
	`FirstName`,
	`LastName`,
	`Address1`,
	`Address2`,
	`City`,
	`State`,
	`Zip`,
	`Country`,
	`Phone`
FROM
	`Account`
WHERE
	`UniqueID` =  pUniqueID;
--endregion




--region `usp_SelectAccountsAll`

------------------------------------------------------------------------------------------------------------------------
-- Author:           Phosphor
-- Procedure Name: `usp_SelectAccountsAll`
-- Date: domingo, 17 de mayo de 2015
------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE `usp_SelectAccountsAll` ()

SELECT
	`AccountID`,
	`UniqueID`,
	`Email`,
	`FirstName`,
	`LastName`,
	`Address1`,
	`Address2`,
	`City`,
	`State`,
	`Zip`,
	`Country`,
	`Phone`
FROM
	`Account`;


--endregion


