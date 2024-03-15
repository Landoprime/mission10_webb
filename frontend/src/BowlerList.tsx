import { Bowler } from './types/Bowler';
import { useEffect, useState } from 'react';

function BowlerList() {
  const [bowlerData, setBowlerData] = useState<Bowler[]>([]);

  useEffect(() => {
    const fetchBowlerData = async () => {
      try {
        const rsp = await fetch('http://localhost:5158/BowlerLeague');
        const data = await rsp.json();
        setBowlerData(data);
      } catch (error) {
        console.error('Error fetching bowler data:', error);
      }
    };
    fetchBowlerData();
  }, []);

  return (
    <>
      <div className="row"></div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Bowler Name</th>
            <th>Team Name</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone Number</th>
          </tr>
        </thead>
        <tbody>
          {bowlerData.map((f) => (
            <tr key={f.bowlerId}>
              <td>
                {f.bowlerFirstName} {f.bowlerMiddleInit} {f.bowlerLastName}
              </td>
              <td>{f.teamName}</td>
              <td>{f.bowlerAddress}</td>
              <td>{f.bowlerCity}</td>
              <td>{f.bowlerState}</td>
              <td>{f.bowlerZip}</td>
              <td>{f.bowlerPhoneNumber}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlerList;
