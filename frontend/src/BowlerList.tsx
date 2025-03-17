import { useEffect, useState } from 'react';
import { bowl } from './types/bowl';

function BowlerList() {
    const [bowls, setBowls] = useState<bowl[]>([]);

    useEffect(() => {
        const fetchBowls = async () => {
            const response = await fetch(
                'https://localhost:5000/api/Bowlers?teamNames=Marlins&teamNames=Sharks'
            );
            //localhost:5000/api/Bowlers?teamNames=Marlins&teamNames=Sharks
            const data = await response.json();
            console.log(data);
            setBowls(data);
        };
        fetchBowls();
    }, []);

    return (
        <>
            <h1>Bowler List</h1>
            <table>
                <thead>
                    <tr>
                        <th>Last Name</th>
                        <th>First Name</th>
                        <th>Middle Initial</th>
                        <th>Team</th>
                        <th>Address</th>
                        <th>City</th>
                        <th>State</th>
                        <th>Zip</th>
                        <th>Phone Number</th>
                    </tr>
                </thead>
                <tbody>
                    {bowls.map((b) => (
                        <tr key={b.bowlerID}>
                            <td>{b.bowlerLastName}</td>
                            <td>{b.bowlerFirstName}</td>
                            <td>{b.bowlerMiddleInit}</td>
                            <td>{b.team.teamName}</td>
                            <td>{b.bowlerAddress}</td>
                            <td>{b.bowlerCity}</td>
                            <td>{b.bowlerState}</td>
                            <td>{b.bowlerZip}</td>
                            <td>{b.bowlerPhoneNumber}</td>
                        </tr>
                    ))}
                </tbody>
            </table>
        </>
    );
}

export default BowlerList;
