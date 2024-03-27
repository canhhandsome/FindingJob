select *
from JobSeeker
select *
from Job

ALTER TABLE apply
DROP CONSTRAINT DF__Apply__TimeApply__3F466844;

alter table apply
drop column timeapply

alter table apply
add timeapply DateTime

Update apply
set timeapply = '2024-01-01'
where JobID = 'j002'

ALTER TABLE apply
ADD status VARCHAR(20) DEFAULT 'waiting';

-- Add a CHECK constraint to restrict values of 'status' to only four options
ALTER TABLE apply
ADD CONSTRAINT chk_status CHECK (status IN ('waiting', 'approve', 'decline'));

Create TABLE JobAlert (
	id varchar(4) default SUBSTRING(CONVERT(VARCHAR(4), NEWID()), 1, 4) primary key,
	sender varchar(255), 
	recipient VARCHAR(255), 
	Subject TEXT, 
	content TEXT,
	DateReply DateTime Default CURRENT_TIMESTAMP
);
